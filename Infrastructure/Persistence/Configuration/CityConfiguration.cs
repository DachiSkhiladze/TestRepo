namespace Infrastructure.Persistence.Configuration;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        ConfigureCityTable(builder);
        ConfigureEventsFK(builder);
    }

    private void ConfigureEventsFK(EntityTypeBuilder<City> builder) 
    {
        builder.OwnsMany(x => x.EventIds, xsb => 
        {
            xsb.ToTable("CityEvents");

            xsb.WithOwner().HasForeignKey("CityId");

            xsb.HasKey("Id");

            xsb.Property(xs => xs.Value)
            .ValueGeneratedNever()
            .HasColumnName("EventId");
        });

        builder.Metadata.FindNavigation(nameof(City.EventIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureCityTable(EntityTypeBuilder<City> builder) 
    {
        builder.ToTable("Cities");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("CityId")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CityId.Create(value));

        builder.Property(x => x.Name)
            .HasMaxLength(70);

        builder.Property(x => x.CountryId)
            .HasConversion(
                id => id.Value,
                value => CountryId.Create(value));
    }
}
