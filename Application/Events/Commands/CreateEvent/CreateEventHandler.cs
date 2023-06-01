namespace Application.Events.Commands.CreateEvent;

public class CreateEventHandler : IRequestHandler<CreateEventCommand, ErrorOr<bool>>
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IEventRepository _eventRepository;
    private readonly ICityRepository _cityRepository;

    public CreateEventHandler(IDateTimeProvider dateTimeProvider, IEventRepository eventRepository, ICityRepository cityRepository) 
    {
        _dateTimeProvider = dateTimeProvider;
        _eventRepository = eventRepository;
        _cityRepository = cityRepository;
    }

    public async Task<ErrorOr<bool>> Handle(CreateEventCommand command, CancellationToken cancellationToken)
    {
        try
        {
            // TODO: I have to add Cloud storage logic

            var createCityIdResult = CityId.Create(command.CityId);

            if (!await _cityRepository.Exists(createCityIdResult)) return Errors.City.NotExist;

            var ev = Domain.Event.Event.Create(
                command.CompanyId,
                Guid.NewGuid().ToString(),
                command.Title,
                command.Description,
                command.Address,
                command.Latitude,
                command.Longitude,
                createCityIdResult,
                command.Price,
                command.Star,
                command.StarVoters,
                EventStatus.PendingApproval,
                command.StartDateTime,
                command.EndDateTime,
                _dateTimeProvider.UtcNow,
                null,
                null,
                command.EventTypes.ConvertAll(eventType => EventType.Create(FilterType.FromValue(eventType))),
                command.EventPictures.ConvertAll(eventPicture => EventPicture.Create(PictureFormat.Webp, true))
                );


            return await _eventRepository.Add(ev, cancellationToken);
        }
        catch (Exception ex)
        {
            return Errors.Event.Unexpected;
        }
    }
}
