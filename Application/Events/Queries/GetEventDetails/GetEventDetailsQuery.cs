using ErrorOr;
using MediatR;


namespace Application.Events.Queries.GetEventDetails
{
    public record GetEventDetailsQuery(int eventId) : IRequest<ErrorOr<GetEventDetailsResult>>;
}
