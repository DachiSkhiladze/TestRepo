namespace Domain.Country;

public sealed class Country : AggregateRoot<CountryId, string>
{
    private readonly List<CityId> _cityIds = new();

    public string Name { get; private set; } = null!;
    public string Flag { get; private set; } = null!;

    public IReadOnlyList<CityId> CityIds => _cityIds.AsReadOnly();

    private Country(CountryId countryId, string name, string flag) : base(countryId)
    {
        Name = name;
        Flag = flag;
    }

    public static Country Create(string code, string name, string flag) 
    {
        // TODO: invariants

        var country = new Country(CountryId.Create(code), name, flag);

        country.AddDomainEvent(new CountryCreated(country));

        return country;
    }


#pragma warning disable CS8618
    private Country() { }

#pragma warning restore CS8618
}
