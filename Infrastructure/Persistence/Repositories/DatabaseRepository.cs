namespace Infrastructure.Persistence.Repositories;

public class DatabaseRepository : IDatabaseRepository
{
    private readonly EventContext _eventContext;

    public DatabaseRepository(EventContext eventContext)
    {
        _eventContext = eventContext;
    }

    public async Task<bool> UpdateDatabase()
    {
        try
        {
            return await _eventContext.Database.EnsureCreatedAsync();
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
