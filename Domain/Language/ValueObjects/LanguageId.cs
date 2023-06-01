namespace Domain.Language.ValueObjects;

public sealed class LanguageId : AggregateRootId<string>
{
    private LanguageId(string value) : base(value)
    {
    }

    private LanguageId(string name, string shortName) : base($"Language_{name}_{shortName}")
    { 
    }

    public static LanguageId Create(string value) => new(value);
    
    public static LanguageId Create(string name, string shortName) => new($"Language_{name}_{shortName}");

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
