namespace Infrastructure.Persistence.Configuration;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        ConfigureLanguagesTable(builder);
    }

    private void ConfigureLanguagesTable(EntityTypeBuilder<Language> builder) 
    {
        builder.ToTable("Languages");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => LanguageId.Create(value));

        builder.Property(x => x.Name)
            .HasMaxLength(25);

        builder.Property(x => x.ShortName)
            .HasMaxLength(5);
    }
}
