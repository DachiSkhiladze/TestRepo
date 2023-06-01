namespace Domain.Event.ValueObjects;

public sealed class EventId : AggregateRootId<Guid>
{
    private EventId(Guid value) : base(value)
    {
    }

    public static EventId CreateUnique() => new(Guid.NewGuid());

    public static EventId Create(Guid value) => new(value);

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
