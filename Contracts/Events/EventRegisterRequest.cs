namespace Contracts.Events;

[BindProperties]
public record EventRegisterRequest(
int EventTypeId,
int EventStatusId,
string EventNameEng,
string? EventNameGeo,
string? EventNameRus,
string DescriptionEng,
string? DescriptionGeo,
string? DescriptionRus,
string ScrollDescriptionEng,
string? ScrollDescriptionGeo,
string? ScrollDescriptionRus,
string Address,
decimal Latitude,
decimal Longitude,
decimal Stars,
decimal Price,
DateTime StartDate,
DateTime EndDate,
int DurationInMinutes,
int CountryId,
int CityId,
int? CompanyId,
IList<IFormFile> Pictures
);
