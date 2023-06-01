namespace Domain.City.Events;

public record CityCreated(City City) : IDomainEvent;

