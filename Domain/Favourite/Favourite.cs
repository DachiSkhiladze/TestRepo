namespace Domain.Favourite;

public sealed class Favourite : AggregateRoot<FavouriteId, string>
{
    public string UserId { get; private set; } = null!;
    public EventId EventId { get; private set; } = null!;
    public DateTime UploadDateTime { get; private set; }
    public DateTime? UpdateDateTime { get; private set; }
    public bool IsActive { get; private set; }

    private Favourite(
        string userId,
        EventId eventId,
        DateTime uploadDateTime,
        DateTime? updateDateTime,
        bool isActive
        ) : base(FavouriteId.Create(eventId, userId)) 
    {
        UserId = userId;
        EventId = eventId;
        UploadDateTime = uploadDateTime;
        UpdateDateTime = updateDateTime;
        IsActive = isActive;
    }

    public static Favourite Create(
        string userId,
        EventId eventId,
        DateTime uploadDateTime,
        DateTime? updateDateTime,
        bool isActive) 
    {
        // TODO: invariants

        var favourite = new Favourite(
            userId,
            eventId,
            uploadDateTime,
            updateDateTime,
            isActive
            );

        favourite.AddDomainEvent(new FavouriteCreated(favourite));

        return favourite;
    }

#pragma warning disable CS8618
    private Favourite() { }

#pragma warning restore CS8618
}
