using ErrorOr;
using MediatR;
using Domain.Common.Errors;
using Application.Common.Interfaces.Persistence;
using Application.Common.Formats;

namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsHandler : IRequestHandler<GetEventDetailsQuery, ErrorOr<GetEventDetailsResult>>
    {
        private readonly IEventRepository _eventRepository;

        public GetEventDetailsHandler(IEventRepository eventRepository) 
        {
            _eventRepository = eventRepository;
        }

        public async Task<ErrorOr<GetEventDetailsResult>> Handle(GetEventDetailsQuery query, CancellationToken cancellationToken)
        {
            //try
            //{
            //    if (await _eventRepository.GetEventById(query.eventId) is not Domain.Events.Event ev) return Errors.Event.NotExist;

            //    var evPics = await _eventRepository.GetEventPicturesById(query.eventId);

            //    string eventType = await _eventRepository.GetEventTypeById(ev.EventTypeId);

            //    if (evPics is null) return Errors.Event.NotExistPicture;

            //    List<string> pictures = evPics.Select(x => PictureFormat.Webp + Convert.ToBase64String(x.Picture)).ToList();

            //    GetEventDetailsResult result = new() 
            //    {
            //        EventId = ev.EventId,
            //        EndDate = ev.EndDate.ToString("ddd, dd MMM yyyy 'at' HH:mm"),
            //        EventNameEng = ev.EventNameEng,
            //        Address = ev.Address,
            //        EventType = eventType,
            //        DescriptionEng = ev.DescriptionEng,
            //        ScrollDescriptionEng = ev.ScrollDescriptionEng,
            //        DurationInMinutes = ev.DurationInMinutes,
            //        Latitude = ev.Latitude,
            //        Longitude = ev.Longitude,
            //        Price = ev.Price,
            //        Stars = ev.Stars,
            //        StartDate = ev.StartDate.ToString("ddd, dd MMM yyyy 'at' HH:mm"),
            //        Pictures = pictures
            //    };

            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    return Errors.Event.Unexpected;
            //}
            return new GetEventDetailsResult();
        }
    }
}
