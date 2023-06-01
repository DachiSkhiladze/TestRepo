namespace Infrastructure.Persistence.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        ConfigureCountriesTable(builder);
        ConfigureCityFK(builder);
    }

    private void ConfigureCityFK(EntityTypeBuilder<Country> builder) 
    {
        builder.OwnsMany(x => x.CityIds, xsb =>
        {
            xsb.ToTable("CountryCities");

            xsb.WithOwner().HasForeignKey("CountryId");

            xsb.HasKey("Id");

            xsb.Property(xs => xs.Value)
            .ValueGeneratedNever()
            .HasColumnName("CityId");
        });

        builder.Metadata.FindNavigation(nameof(Country.CityIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureCountriesTable(EntityTypeBuilder<Country> builder) 
    {
        builder.ToTable("Countries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CountryId.Create(value))
            .HasColumnName("CountryId");

        builder.Property(x => x.Name)
            .HasMaxLength(70);

        builder.Property(x => x.Flag)
            .HasMaxLength(36);
    }
}
