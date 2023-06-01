using ErrorOr;
using MediatR;
using Domain.Common.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces.Persistence;
using Application.Common.Formats;

namespace Application.Events.Queries.GetSliderEvents
{
    public class GetSliderEventsHandler : IRequestHandler<GetSliderEventsQuery, ErrorOr<List<GetSliderEventsResult>>>
    {
        private readonly IEventRepository _eventRepository;

        public GetSliderEventsHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<ErrorOr<List<GetSliderEventsResult>>> Handle(GetSliderEventsQuery request, CancellationToken cancellationToken)
        {
            //try
            //{
            //    var events = await _eventRepository.GetPaidEvents();

            //    var result = new List<GetSliderEventsResult>();

            //    foreach (var ev in events)
            //    {
            //        var pic = await _eventRepository.GetEventPictureById(ev.EventId);

            //        result.Add(new GetSliderEventsResult()
            //        {
            //            EventId = ev.EventId,
            //            Address = ev.Address,
            //            Date = ev.StartDate.ToString("ddd, dd MMM 'at' HH:mm"),
            //            Title = ev.EventNameEng,
            //            Picture = PictureFormat.Webp + Convert.ToBase64String(pic)
            //        });
            //    }

            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    return Errors.Event.Unexpected;
            //}
            return new List<GetSliderEventsResult>();
        }
    }
}
