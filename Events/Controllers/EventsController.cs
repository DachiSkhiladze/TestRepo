namespace Events.Controllers;

[Route(Routes.Events.Controller)]
public class EventsController : ApiController
{
    public EventsController(ISender mediator, IMapper mapper) : base(mediator, mapper) { }


    [HttpPost(Routes.Events.CreateEvent)]
    [Consumes(ContentType.FORM)]
    public async Task<IActionResult> CreateEvent([FromForm]CreateEventRequest request) 
    {
        CreateEventCommand command = new(
            request.CompanyId,
            request.Picture,
            request.Title,
            request.Description,
            request.Address,
            request.Latitude,
            request.Longitude,
            request.CityId,
            request.Price,
            request.Star,
            request.StarVoters,
            request.StartDateTime,
            request.EndDateTime,
            request.EventTypes,
            request.EventPictures
            );
        return Ok();
    }

    //[HttpPost(Routes.Events.EventRegister)]
    //[Consumes(ContentType.FORM)]
    //public async Task<IActionResult> EventRegister([FromForm]EventRegisterRequest request) 
    //{
    //    EventRegisterCommand command = new(
    //        request.EventTypeId,
    //        request.EventStatusId,
    //        request.EventNameEng,
    //        request.EventNameGeo,
    //        request.EventNameRus,
    //        request.DescriptionEng,
    //        request.DescriptionGeo,
    //        request.DescriptionRus,
    //        request.ScrollDescriptionEng,
    //        request.ScrollDescriptionGeo,
    //        request.ScrollDescriptionRus,
    //        request.Address,
    //        request.Latitude,
    //        request.Longitude,
    //        request.Stars,
    //        request.Price,
    //        request.StartDate,
    //        request.EndDate,
    //        request.DurationInMinutes,
    //        request.CountryId,
    //        request.CityId,
    //        request.CompanyId,
    //        request.Pictures
    //        );

    //    //var command = _mapper.Map<EventRegisterCommand>(request);

    //    var result = await _mediator.Send(command);

    //    return result.Match(result => Ok(), errors => Problem(errors));
    //}

    //[HttpGet(Routes.Events.GetFilteredEvents)]
    //public async Task<IActionResult> GetFilteredEvents([FromQuery] int[]? typeIds) 
    //{
    //    GetFilteredEventsQuery query = new(typeIds);

    //    var events = await _mediator.Send(query);

    //    return events.Match(events => Ok(events), errors => Problem(errors));
    //}

    //[HttpGet(Routes.Events.GetEventDetails)]
    //public async Task<IActionResult> GetEventDetails(int eventId) 
    //{
    //    GetEventDetailsQuery query = new(eventId);
    //    var eventDetails = await _mediator.Send(query);

    //    return eventDetails.Match(eventDetails => Ok(eventDetails), errors => Problem(errors));
    //}

    //[HttpGet(Routes.Events.GetSliderEvents)]
    //public async Task<IActionResult> GetSliderEvents() 
    //{
    //    GetSliderEventsQuery query = new();
    //    var events = await _mediator.Send(query);

    //    return events.Match(events => Ok(events), errors => Problem(errors));
    //}

    //[HttpGet(Routes.Events.GetEventsByCompanyName)]
    //public async Task<IActionResult> GetEventsByCompanyName(string name) 
    //{
    //    GetEventsByCompanyNameQuery query = new(name);
        
    //    var events = await _mediator.Send(query);

    //    return events.Match(events => Ok(events), errors => Problem(errors));
    //}
}
