namespace Domain.Country.ValueObjects;

public sealed class CountryId : AggregateRootId<string>
{
    private CountryId(string value) : base(value)
    {
    }

    public static CountryId Create(string value) => new(value);
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
