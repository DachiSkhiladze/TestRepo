using Application.Common.Interfaces.Persistence;
using Application.Common.Interfaces.Services;
using ErrorOr;
using MediatR;
using Domain.Common.Errors;
using RouteGO.Models;

namespace Application.Events.Queries.GetEventsByCompanyName
{
    public class GetEventsByCompanyNameHandler : IRequestHandler<GetEventsByCompanyNameQuery, ErrorOr<EventsByCompanyNameResult>>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEventBus _eventBus;

        public GetEventsByCompanyNameHandler(IEventRepository eventRepository, IEventBus eventBus)
        {
            _eventRepository = eventRepository;
            _eventBus = eventBus;
        }

        public async Task<ErrorOr<EventsByCompanyNameResult>> Handle(GetEventsByCompanyNameQuery query, CancellationToken cancellationToken)
        {
            //try
            //{
            //    Uri uri = new Uri("amqp://94.43.166.107:5672/companyQueue2");
            //    var res = new EventsByCompanyNameResult();
            //    Message message = new Message(Guid.NewGuid(), query.name);
            //    await _eventBus.PublishAsync(message, uri, cancellationToken);
            //    Console.WriteLine("Sending Data: ");

            //    return res;
            //}
            //catch (Exception ex)
            //{
            //    return Errors.Event.Unexpected;
            //}
            return new EventsByCompanyNameResult();
        }
    }
}
