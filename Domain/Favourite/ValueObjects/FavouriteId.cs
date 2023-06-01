namespace Domain.Favourite.ValueObjects;

public sealed class FavouriteId : AggregateRootId<string>
{
    private FavouriteId(string value) : base(value)
    {
    }

    private FavouriteId(EventId eventId, string userId) : base($"Favourite_{eventId.Value}_{userId}")
    { 
    }

    public static FavouriteId Create(string value) => new(value);

    public static FavouriteId Create(EventId eventId, string userId) => new(eventId, userId);

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
