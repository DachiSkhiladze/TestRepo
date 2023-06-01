namespace Domain.Language.Events;

public record LanguageCreated(Language Language) : IDomainEvent;
