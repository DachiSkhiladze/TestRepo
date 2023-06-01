namespace Application.Database.Commands;

public class CreateDatabaseCommandValidator : AbstractValidator<CreateDatabaseCommand>
{
    public CreateDatabaseCommandValidator() 
    {
        RuleFor(x => x.Password).NotEmpty();
    }
}
