namespace Application.Events.Common;

public class FileValidator : AbstractValidator<IFormFile>
{
    public FileValidator()
    {
        RuleFor(x => x.Length).NotNull().LessThanOrEqualTo(Limit.File.SIZE)
            .WithMessage(Errors.File.SIZE);

        RuleFor(x => x.ContentType).NotNull().Must(x => x.Equals(Limit.File.WEBP))
            .WithMessage(Errors.File.TYPE);
    }
}
