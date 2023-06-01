namespace Domain.Event;

public sealed class Event : AggregateRoot<EventId, Guid>
{
    private readonly List<EventType> _eventTypes = new();
    private readonly List<EventPicture> _eventPictures = new();
    private readonly List<FavouriteId> _favouriteIds = new();

    public int CompanyId { get; private set; }
    public string Picture { get; private set; } = null!;
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string Address { get; private set; } = null!;
    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }
    public CityId CityId { get; private set; } = null!;
    public decimal? Price { get; private set; }
    public decimal Star { get; private set; }
    public int StarVoters { get; private set; }
    public EventStatus EventStatus { get; private set; } = null!;
    public DateTime StartDateTime { get; private set; }
    public DateTime EndDateTime { get; private set; }
    public DateTime UploadDateTime { get; private set; }
    public DateTime? UpdateDateTime { get; private set; }
    public DateTime? DeleteDateTime { get; private set; }

    public IReadOnlyList<EventType> EventTypes => _eventTypes.AsReadOnly();
    public IReadOnlyList<EventPicture> EventPictures => _eventPictures.AsReadOnly();
    public IReadOnlyList<FavouriteId> FavouriteIds => _favouriteIds.AsReadOnly();

    private Event(
        EventId id,
        int companyId,
        string picture,
        string title,
        string description,
        string address,
        decimal latitude,
        decimal longitude,
        CityId cityId,
        decimal? price,
        decimal star,
        int starVoters,
        EventStatus eventStatus,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime uploadDateTime,
        DateTime? updateDateTime,
        DateTime? deleteDateTime,
        List<EventType> eventTypes,
        List<EventPicture> eventPictures
        ) : base(id)
    {
        CompanyId = companyId;
        Picture = picture;
        Title = title;
        Description = description;
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
        CityId = cityId;
        Price = price;
        Star = star;
        StarVoters = starVoters;
        EventStatus = eventStatus;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        UploadDateTime = uploadDateTime;
        UpdateDateTime = updateDateTime;
        DeleteDateTime = deleteDateTime;
        _eventPictures = eventPictures;
        _eventTypes = eventTypes;
    }

    public static Event Create(
        int companyId,
        string picture,
        string title,
        string description,
        string address,
        decimal latitude,
        decimal longitude,
        CityId cityId,
        decimal? price,
        decimal star,
        int starVoters,
        EventStatus eventStatus,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime uploadDateTime,
        DateTime? updateDateTime,
        DateTime? deleteDateTime,
        List<EventType>? eventTypes = null,
        List<EventPicture>? eventPictures = null
        )
    {
        // TODO: enforce invariants

        var ev = new Event(
            EventId.CreateUnique(),
            companyId,
            picture,
            title,
            description,
            address,
            latitude,
            longitude,
            cityId,
            price,
            star,
            starVoters,
            eventStatus,
            startDateTime,
            endDateTime,
            uploadDateTime,
            updateDateTime,
            deleteDateTime,
            eventTypes ?? new(),
            eventPictures ?? new());

        ev.AddDomainEvent(new EventCreated(ev));

        return ev;
    }


#pragma warning disable CS8618
    private Event() { }

#pragma warning restore CS8618

}
