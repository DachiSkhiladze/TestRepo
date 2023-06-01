namespace Infrastructure.Persistence.Repositories;

public class CityRepository : ICityRepository
{
    private readonly EventContext _eventContext;

    public CityRepository(EventContext eventContext) 
    {
        _eventContext = eventContext;
    }

    public async Task<bool> Exists(CityId cityId)
    {
        return await _eventContext.Cities.AnyAsync(city => city.Id == cityId);
    }
}
