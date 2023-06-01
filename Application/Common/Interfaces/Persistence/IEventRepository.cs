namespace Application.Common.Interfaces.Persistence;

public interface IEventRepository
{
    //Task<ErrorOr<int>> AddEvent(Domain.Events.Event ev);
    //Task<ErrorOr<bool>> AddEventPictures(List<Domain.EventPictures.EventPicture> pictures);
    //Task<List<Domain.EventPictures.EventPicture>?> GetEventPicturesById(int eventId);
    //Task<List<Domain.EventPictures.EventPicture>?> GetDeletedEventPicturesById(int eventId);
    //Task<ErrorOr<bool>> RemoveEventPictures(List<Domain.EventPictures.EventPicture> eventPictures);
    //Task<ErrorOr<bool>> UpdateEvent(Domain.Events.Event ev);
    //Task<ErrorOr<bool>> RemoveEvent(Domain.Events.Event ev);
    //Task<Domain.Events.Event?> GetEventById(int eventId);
    //Task<ErrorOr<List<Domain.Events.Event>>> GetEvents(int[]? arr);
    //Task<byte[]> GetEventPictureById(int eventId);
    //Task<bool> CheckEvent(int eventId);
    //Task<string> GetEventTypeById(int eventTypeId);
    //Task<List<Domain.Events.Event>> GetPaidEvents();

    Task<ErrorOr<bool>> Add(Domain.Event.Event ev, CancellationToken cancellationToken);
}
