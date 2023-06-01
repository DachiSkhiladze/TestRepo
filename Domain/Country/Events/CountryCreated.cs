namespace Domain.Country.Events;

public record CountryCreated(Country Country) : IDomainEvent;
