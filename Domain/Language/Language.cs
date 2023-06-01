namespace Domain.Language;

public sealed class Language : AggregateRoot<LanguageId, string>
{
    public string Name { get; private set; } = null!;
    public string ShortName { get; private set; } = null!;

    private Language(LanguageId id, string name, string shortName) : base(id)
    {
        Name = name;
        ShortName = shortName;
    }

    public static Language Create(string name, string shortName) 
    {
        // TODO: invariants

        var language = new Language(LanguageId.Create(name, shortName), name, shortName);

        language.AddDomainEvent(new LanguageCreated(language));

        return language;
    }

#pragma warning disable CS8618
    private Language() { }

#pragma warning restore CS8618
}
