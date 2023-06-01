namespace Domain.Event.Events;

public record EventCreated(Event Event) : IDomainEvent;

