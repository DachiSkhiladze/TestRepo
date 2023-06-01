
using ErrorOr;
using MediatR;

namespace Application.Events.Queries.GetFilteredEvents
{
    public record GetFilteredEventsQuery(int[]? typeIds) : IRequest<ErrorOr<List<GetFilteredEventsResult>>>;
}
