using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetSliderEvents
{
    public record GetSliderEventsQuery() : IRequest<ErrorOr<List<GetSliderEventsResult>>>;
}
