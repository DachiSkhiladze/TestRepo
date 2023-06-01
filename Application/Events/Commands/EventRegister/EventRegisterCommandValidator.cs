namespace Application.Events.Commands.EventRegister;

public class EventRegisterCommandValidator : AbstractValidator<EventRegisterCommand>
{
    public EventRegisterCommandValidator() 
    {
        RuleFor(x => x.EventTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.EventStatusId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.EventNameEng).NotEmpty();
        RuleFor(x => x.DescriptionEng).NotEmpty();
        RuleFor(x => x.Latitude).NotEmpty();
        RuleFor(x => x.Longitude).NotEmpty();
        RuleFor(x => x.Price).NotEmpty();
        RuleFor(x => x.StartDate).NotEmpty().LessThanOrEqualTo(x => x.EndDate);
        RuleFor(x => x.EndDate).NotEmpty().GreaterThanOrEqualTo(x => x.StartDate);
        RuleFor(x => x.DurationInMinutes).NotEmpty();
        RuleFor(x => x.Address).NotEmpty();
        RuleFor(x => x.CityId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.CountryId).NotEmpty().GreaterThan(0);
        RuleForEach(x => x.Pictures).NotEmpty().SetValidator(new FileValidator());
    }
}
