namespace Infrastructure.Persistence.Configuration;

public class FavouriteConfiguration : IEntityTypeConfiguration<Favourite>
{
    public void Configure(EntityTypeBuilder<Favourite> builder)
    {
        ConfigureFavouritesTable(builder);
    }

    private void ConfigureFavouritesTable(EntityTypeBuilder<Favourite> builder) 
    {
        builder.ToTable("Favourites");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("FavouriteId")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => FavouriteId.Create(value));

        builder.Property(x => x.UserId)
            .HasMaxLength(450);

        builder.Property(x => x.EventId)
            .HasConversion(
                id => id.Value,
                value => EventId.Create(value));

        builder.Property(x => x.UploadDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.UpdateDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.IsActive);
    }
}
