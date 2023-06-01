namespace Application.Database.Commands;

public record CreateDatabaseCommand(string Password) : IRequest<ErrorOr<bool>>;
