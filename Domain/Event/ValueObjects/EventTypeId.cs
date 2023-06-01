namespace Domain.Event.ValueObjects;

public sealed class EventTypeId : EntityId<Guid>
{
    private EventTypeId(Guid value) : base(value)
    {
    }

    public static EventTypeId CreateUnique() => new(Guid.NewGuid());

    public static EventTypeId Create(Guid value) => new(value);

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
