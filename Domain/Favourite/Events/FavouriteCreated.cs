namespace Domain.Favourite.Events;

public record FavouriteCreated(Favourite Favourite) : IDomainEvent;

