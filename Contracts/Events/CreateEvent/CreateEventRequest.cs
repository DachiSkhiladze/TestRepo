namespace Contracts.Events.CreateEvent;

public record CreateEventRequest(
    int CompanyId,
    IFormFile Picture,
    string Title,
    string Description,
    string Address,
    decimal Latitude,
    decimal Longitude,
    string CityId,
    decimal? Price,
    decimal Star,
    int StarVoters,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<int> EventTypes,
    List<IFormFile> EventPictures
    );


