namespace Domain.Event.Events;

public record EventPictureCreated(EventPicture EventPicture) : IDomainEvent;
