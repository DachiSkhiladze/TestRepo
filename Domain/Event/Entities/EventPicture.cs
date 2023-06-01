namespace Domain.Event.Entities;

public sealed class EventPicture : Entity<EventPictureId>
{
    public string Format { get; private set; } = null!;
    public bool IsActive { get; private set; }

    private EventPicture(EventPictureId id, string format, bool isActive) : base(id) 
    {
        Format = format;
        IsActive = isActive;
    }

    public static EventPicture Create(string format, bool isActive)
    {
        // TODO: invariants

        var picture = new EventPicture(EventPictureId.CreateUnique(), format, isActive);

        picture.AddDomainEvent(new EventPictureCreated(picture));

        return picture;
    }


#pragma warning disable CS8618
    private EventPicture() { }

#pragma warning restore CS8618
}
