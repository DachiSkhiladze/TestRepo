namespace Application.Events.Commands.CreateEvent;

public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidator() 
    {
        RuleFor(x => x.CompanyId).NotEmpty().NotNull();
        RuleFor(x => x.Picture).NotEmpty().SetValidator(new FileValidator());
        RuleFor(x => x.Title).NotEmpty().NotNull();
        RuleFor(x => x.Description).NotEmpty().NotNull();
        RuleFor(x => x.Address).NotEmpty().NotNull();
        RuleFor(x => x.Latitude).NotNull();
        RuleFor(x => x.Longitude).NotNull();
        RuleFor(x => x.CityId).NotEmpty().NotNull();
        // TODO: Price validation if it is not null
        RuleFor(x => x.StarVoters).NotNull().GreaterThanOrEqualTo(Limit.Enums.Zero);
        RuleFor(x => x.Star).NotNull().GreaterThanOrEqualTo(Limit.Enums.Zero).LessThanOrEqualTo(Limit.Enums.EventTypeUpperBound);
        RuleFor(x => x.StartDateTime).NotNull();
        RuleFor(x => x.EndDateTime).NotNull();
        RuleForEach(x => x.EventPictures).NotEmpty().SetValidator(new FileValidator());
        RuleForEach(x => x.EventTypes).NotNull().GreaterThanOrEqualTo(Limit.Enums.Zero).LessThanOrEqualTo(Limit.Enums.EventTypeUpperBound);
    }
}
