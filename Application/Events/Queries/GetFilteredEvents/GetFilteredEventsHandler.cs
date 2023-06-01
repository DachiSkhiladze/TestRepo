using ErrorOr;
using MediatR;
using Domain.Common.Errors;
using Application.Common.Interfaces.Persistence;
using Application.Common.Formats;

namespace Application.Events.Queries.GetFilteredEvents
{
    public class GetFilteredEventsHandler : IRequestHandler<GetFilteredEventsQuery, ErrorOr<List<GetFilteredEventsResult>>>
    {
        private readonly IEventRepository _eventRepository;

        public GetFilteredEventsHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<ErrorOr<List<GetFilteredEventsResult>>> Handle(GetFilteredEventsQuery query, CancellationToken cancellationToken)
        {
            //try
            //{
            //    var events = await _eventRepository.GetEvents(query.typeIds);

            //    if (events.IsError) 
            //    {
            //        return events.Errors;
            //    }

            //    var result = new List<GetFilteredEventsResult>();

            //    foreach (var ev in events.Value)
            //    {
            //        byte[] eventPicture = await _eventRepository.GetEventPictureById(ev.EventId);
            //        string picture = PictureFormat.Webp + Convert.ToBase64String(eventPicture);
            //        result.Add(new GetFilteredEventsResult()
            //        {
            //            EventId = ev.EventId,
            //            CompanyName = "",
            //            Picture = picture,
            //            Title = ev.EventNameEng,
            //            ScrollDescription = ev.ScrollDescriptionEng
            //        });
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    return Errors.Event.Unexpected;
            //}
            return new List<GetFilteredEventsResult>();
        }
    }
}
