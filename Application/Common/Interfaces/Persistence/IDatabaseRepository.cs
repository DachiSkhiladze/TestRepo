namespace Application.Common.Interfaces.Persistence;

public interface IDatabaseRepository
{
    Task<bool> UpdateDatabase();
}
