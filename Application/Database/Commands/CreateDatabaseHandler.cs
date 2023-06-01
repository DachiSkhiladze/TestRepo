namespace Application.Database.Commands;

public class CreateDatabaseHandler : IRequestHandler<CreateDatabaseCommand, ErrorOr<bool>>
{
    private readonly IDatabaseRepository _databaseRepository;

    public CreateDatabaseHandler(IDatabaseRepository databaseRepository)
    {
        _databaseRepository = databaseRepository;
    }

    public async Task<ErrorOr<bool>> Handle(CreateDatabaseCommand command, CancellationToken cancellationToken)
    {
        try
        {
            if (command.Password != "Paroli@123")
            {
                return Errors.Database.InvalidCredentials;
            }

            var result = await _databaseRepository.UpdateDatabase();

            if (!result)
            {
                return Errors.Database.Unexpected;
            }

            return true;

        }
        catch (Exception ex)
        {
            return Errors.Database.Unexpected;
        }
    }
}
