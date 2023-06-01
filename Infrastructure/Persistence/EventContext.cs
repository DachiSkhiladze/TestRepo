namespace Infrastructure.Persistence;

public class EventContext : DbContext
{
    private readonly  PublishDomainEventsInterceptor _publishDomainEventsInterceptor;
    
    public EventContext(DbContextOptions<EventContext> options, PublishDomainEventsInterceptor publishDomainEventsInterceptor) : base(options)
    {
        _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
    }

    public virtual DbSet<Domain.Event.Event> Events { get; set; } = null!;
    public virtual DbSet<Favourite> Favourites { get; set; } = null!;
    public virtual DbSet<Country> Countries { get; set; } = null!;
    public virtual DbSet<City> Cities { get; set; } = null!;
    public virtual DbSet<Language> Languages { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(EventContext).Assembly);
        base.OnModelCreating(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}
