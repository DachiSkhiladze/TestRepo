namespace Domain.Event.Entities;

public sealed class EventType : Entity<EventTypeId>
{
    public FilterType FilterType { get; private set; }

    private EventType(EventTypeId id, FilterType filterType) : base(id)
    {
        FilterType = filterType;
    }

    public static EventType Create(FilterType filterType) 
    {
        // TODO: invariants

        var eventType = new EventType(EventTypeId.CreateUnique(), filterType);

        eventType.AddDomainEvent(new EventTypeCreated(eventType));

        return eventType;
    }

#pragma warning disable CS8618
    private EventType() { }

#pragma warning restore CS8618
}
