namespace Event.Application.Events.Commands.EventRegister;

public class EventRegisterHandler : IRequestHandler<EventRegisterCommand, ErrorOr<bool>>
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IEventRepository _eventRepository;
    private readonly IFileProvider _fileProvider;

    public EventRegisterHandler(IDateTimeProvider dateTimeProvider, IEventRepository eventRepository, IFileProvider fileProvider)
    {
        _dateTimeProvider = dateTimeProvider;
        _eventRepository = eventRepository;
        _fileProvider = fileProvider;
    }

    public async Task<ErrorOr<bool>> Handle(EventRegisterCommand command, CancellationToken cancellationToken)
    {
        //try
        //{
        //    Domain.Events.Event ev = new()
        //    {
        //        DescriptionEng = command.DescriptionEng,
        //        EventStatusId = command.EventStatusId,
        //        DescriptionGeo = command.DescriptionGeo,
        //        DescriptionRus = command.DescriptionRus,
        //        Address = command.Address,
        //        CompanyId = command.CompanyId,
        //        DurationInMinutes = command.DurationInMinutes,
        //        EndDate = command.EndDate,
        //        EventNameEng = command.EventNameEng,
        //        EventNameGeo = command.EventNameGeo,
        //        EventNameRus = command.EventNameRus,
        //        EventTypeId = command.EventTypeId,
        //        ScrollDescriptionEng = command.ScrollDescriptionEng,
        //        IsActive = true,
        //        Latitude = command.Latitude,
        //        Longitude = command.Longitude,
        //        ScrollDescriptionGeo = command.ScrollDescriptionGeo,
        //        ScrollDescriptionRus = command.ScrollDescriptionRus,
        //        Stars = 0,
        //        CityId = command.CityId,
        //        CountryId = command.CountryId,
        //        StartDate = command.StartDate,
        //        Price = command.Price,
        //        UploadDate = _dateTimeProvider.UtcNow
        //    };

        //    var add = await _eventRepository.AddEvent(ev);

        //    if (add.IsError) 
        //    {
        //        return add.Errors;
        //    }

        //    List<Domain.EventPictures.EventPicture> eventPictures = new List<Domain.EventPictures.EventPicture>();

        //    foreach (var st in command.Pictures)
        //    {
        //        eventPictures.Add(new Domain.EventPictures.EventPicture 
        //        {
        //            EventId = add.Value,
        //            IsActive = true,
        //            UploadDate = _dateTimeProvider.UtcNow,
        //            Picture = _fileProvider.GetBytesFromFormFile(st)
        //        });
        //    }

        //    var result = await _eventRepository.AddEventPictures(eventPictures);

        //    if (result.IsError) 
        //    {
        //        var addedPictures = await _eventRepository.GetEventPicturesById(add.Value);

        //        if (addedPictures is not null)
        //        {
        //            var removePics = await _eventRepository.RemoveEventPictures(addedPictures);
        //        }

        //        var evenT = await _eventRepository.GetEventById(add.Value);

        //        if (evenT is not null) 
        //        {
        //            var removeEvent = await _eventRepository.RemoveEvent(evenT);
        //        }

        //        return result.Errors;
        //    }

        //    return true;
        //}
        //catch (Exception ex)
        //{
        //    return Errors.Event.Unexpected;
        //}
        return true;
    }
}
