namespace Domain.City.ValueObjects;

public sealed class CityId : AggregateRootId<string>
{
    private CityId(string value) : base(value)
    {
    }

    private CityId(CountryId countryId, string name) : base($"City_{countryId.Value}_{name}")
    {
    }

    public static CityId Create(string value) => new(value);

    public static CityId Create(CountryId countryId, string name) => new($"City_{countryId.Value}_{name}");

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
