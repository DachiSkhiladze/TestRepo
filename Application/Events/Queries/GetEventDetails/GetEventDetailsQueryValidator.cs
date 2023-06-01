using FluentValidation;


namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQueryValidator : AbstractValidator<GetEventDetailsQuery>
    {
        public GetEventDetailsQueryValidator() 
        {
            RuleFor(x => x.eventId).NotEmpty().GreaterThan(0);
        }
    }
}
