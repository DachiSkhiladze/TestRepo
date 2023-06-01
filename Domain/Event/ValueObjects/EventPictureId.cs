namespace Domain.Event.ValueObjects;

public sealed class EventPictureId : EntityId<Guid>
{
    private EventPictureId(Guid value) : base(value)
    {
    }

    public static EventPictureId CreateUnique() => new(Guid.NewGuid());

    public static EventPictureId Create(Guid value) => new(value);
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
