namespace Domain.City;

public sealed class City : AggregateRoot<CityId, string>
{
    private readonly List<EventId> _eventIds = new();

    public string Name { get; private set; } = null!;
    public CountryId CountryId { get; private set; } = null!;

    public IReadOnlyList<EventId> EventIds => _eventIds.AsReadOnly();

    private City(CityId id, string name, CountryId countryId) : base(CityId.Create(countryId, name))
    {
        Name = name;
        CountryId = countryId;
    }

    public static City Create(string name, CountryId countryId)
    {
        // TODO: invariants

        var city = new City(CityId.Create(countryId, name), name, countryId);

        city.AddDomainEvent(new CityCreated(city));

        return city;
    }


#pragma warning disable CS8618
    private City() { }

#pragma warning restore CS8618
}
