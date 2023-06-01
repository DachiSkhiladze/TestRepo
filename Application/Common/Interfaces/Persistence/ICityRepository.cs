namespace Application.Common.Interfaces.Persistence;

public interface ICityRepository
{
    Task<bool> Exists(CityId city);
}
