namespace Infrastructure.Persistence.Configuration;

public class EventConfiguration : IEntityTypeConfiguration<Domain.Event.Event>
{
    public void Configure(EntityTypeBuilder<Domain.Event.Event> builder)
    {
        ConfigureEventsTable(builder);
        ConfigureEventPicturesTable(builder);
        ConfigureEventTypesTable(builder);
        ConfigureFavouriteFK(builder);
    }

    private void ConfigureFavouriteFK(EntityTypeBuilder<Domain.Event.Event> builder) 
    {
        builder.OwnsMany(x => x.FavouriteIds, xsb =>
        {
            xsb.ToTable("FavouriteEvents");

            xsb.WithOwner().HasForeignKey("EventId");

            xsb.HasKey("Id");

            xsb.Property(xs => xs.Value)
            .ValueGeneratedNever()
            .HasColumnName("FavouriteId");
        });

        builder.Metadata.FindNavigation(nameof(Domain.Event.Event.FavouriteIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureEventTypesTable(EntityTypeBuilder<Domain.Event.Event> builder) 
    {
        builder.OwnsMany(x => x.EventTypes, sb => 
        {
            sb.ToTable("EventTypes");

            sb.WithOwner().HasForeignKey("EventId");

            sb.HasKey(x => x.Id);

            sb.Property(s => s.Id)
                .HasColumnName("EventTypeId")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => EventTypeId.Create(value));

            sb.Property(r => r.FilterType)
                .HasConversion(
                    status => status.Value,
                    value => FilterType.FromValue(value));
        });

        builder.Metadata.FindNavigation(nameof(Domain.Event.Event.EventTypes))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureEventPicturesTable(EntityTypeBuilder<Domain.Event.Event> builder) 
    {
        builder.OwnsMany(x => x.EventPictures, sb => 
        {
            sb.ToTable("EventPictures");

            sb.WithOwner().HasForeignKey("EventId");

            sb.HasKey(x => x.Id);

            sb.Property(s => s.Id)
            .HasColumnName("EventPictureId")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => EventPictureId.Create(value));

            sb.Property(s => s.Format)
            .HasMaxLength(36);

            sb.Property(s => s.IsActive);
        });

        builder.Metadata.FindNavigation(nameof(Domain.Event.Event.EventPictures))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureEventsTable(EntityTypeBuilder<Domain.Event.Event> builder) 
    {
        builder.ToTable("Events");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("EventId")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => EventId.Create(value));

        builder.Property(x => x.CompanyId);

        builder.Property(x => x.Picture)
            .HasMaxLength(36);

        builder.Property(x => x.Title)
            .HasMaxLength(100);

        builder.Property(x => x.Description);

        builder.Property(x => x.Address)
            .HasMaxLength(150);

        builder.Property(x => x.Latitude)
            .HasColumnType("decimal(8, 6)");

        builder.Property(x => x.Longitude)
            .HasColumnType("decimal(9, 6)");

        builder.Property(x => x.CityId)
            .HasConversion(
                id => id.Value,
                value => CityId.Create(value));

        builder.Property(x => x.Price)
            .HasColumnType("decimal(10, 2)");

        builder.Property(x => x.Star)
            .HasColumnType("decimal(2, 1)");

        builder.Property(x => x.StarVoters);

        builder.Property(x => x.EventStatus)
            .HasConversion(
                status => status.Value,
                value => EventStatus.FromValue(value));

        builder.Property(x => x.StartDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.EndDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.UploadDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.UpdateDateTime)
            .HasColumnType("datetime");

        builder.Property(x => x.DeleteDateTime)
            .HasColumnType("datetime");
    }
}
