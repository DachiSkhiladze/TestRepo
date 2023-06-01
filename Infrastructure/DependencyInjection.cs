namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddAuth(configuration);
        services.AddPersistance(configuration);
        services.AddCompression();
        services.AddMessageBroker(configuration);

        services.AddHttpContextAccessor();

        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IFileProvider, FileProvider>();

        return services;
    }

    public static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<EventContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString(ContextSettings.ContextName)));

        services.AddScoped<PublishDomainEventsInterceptor>();
        services.AddScoped<IDatabaseRepository, DatabaseRepository>();
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<ICityRepository, CityRepository>();

        return services;
    }

    public static IServiceCollection AddAuth(this IServiceCollection services, ConfigurationManager configuration)
    {
        var jwtSetting = new JwtSettings();
        configuration.Bind(JwtSettings.SectionName, jwtSetting);

        services.AddSingleton(Options.Create(jwtSetting));

        services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSetting.Issuer,
                ValidAudience = jwtSetting.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSetting.Secret))
            });

        return services;
    }

    public static IServiceCollection AddCompression(this IServiceCollection services)
    {
        services.AddResponseCompression(options =>
        {
            options.EnableForHttps = true;
            options.Providers.Add<GzipCompressionProvider>();
            options.Providers.Add<BrotliCompressionProvider>();
        });
        return services;
    }

    public static IServiceCollection AddMessageBroker(this IServiceCollection services, ConfigurationManager configuration)
    {
        MessageBrokerSettings messageBrokerSettings = new();

        configuration.Bind(MessageBrokerSettings.SectionName, messageBrokerSettings);

        services.AddSingleton(Options.Create(messageBrokerSettings));

        services.AddMassTransit(busConfigurator =>
        {

            busConfigurator.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cur =>
            {
                cur.Host(new Uri(messageBrokerSettings.Host), h =>
                {
                    h.Username(messageBrokerSettings.UserName);
                    h.Password(messageBrokerSettings.Password);
                });
            }));

            services.AddMassTransitHostedService();

        });

        services.AddTransient<IEventBus, EventBus>();

        return services;
    }
}
