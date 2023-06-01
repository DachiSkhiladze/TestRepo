namespace Domain.Event.Events;

public record EventTypeCreated(EventType EventType) : IDomainEvent;

