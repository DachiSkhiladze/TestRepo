namespace Infrastructure.Persistence.Repositories;

public class EventRepository : IEventRepository
{
    private readonly EventContext _eventContext;

    public EventRepository(EventContext eventContext)
    {
        _eventContext = eventContext;
    }

    public async Task<ErrorOr<bool>> Add(Domain.Event.Event ev, CancellationToken cancellationToken) 
    {
        try
        {
            await _eventContext.AddAsync(ev);

            await _eventContext.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (Exception ex)
        {
            return Errors.Event.AddEvent;
        }
    }

    //public async Task<ErrorOr<int>> AddEvent(Domain.Events.Event ev)
    //{
    //    try
    //    {
    //        var add = await _eventContext.Events.AddAsync(ev);
    //        await _eventContext.SaveChangesAsync();

    //        if (add.Entity.EventId is 0) 
    //        {
    //            return Errors.Event.AddEvent;
    //        }
    //        return add.Entity.EventId;
    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<ErrorOr<bool>> AddEventPictures(List<EventPicture> pictures) 
    //{
    //    try
    //    {
    //        await _eventContext.EventPictures.AddRangeAsync(pictures);
    //        await _eventContext.SaveChangesAsync();

    //        return true;
    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<List<EventPicture>?> GetEventPicturesById(int eventId) 
    //{
    //    return await _eventContext.EventPictures.Where(x => x.EventId == eventId && x.IsActive).ToListAsync();
    //}

    //public async Task<byte[]> GetEventPictureById(int eventId)
    //{
    //    var picture = await _eventContext.EventPictures.Where(x => x.EventId == eventId && x.IsActive).FirstOrDefaultAsync();
    //    if (picture is not EventPicture) 
    //    {
    //        return new byte[] {};
    //    }
    //    return picture.Picture;
    //}

    //public async Task<List<EventPicture>?> GetDeletedEventPicturesById(int eventId)
    //{
    //    return await _eventContext.EventPictures.Where(x => x.EventId == eventId && !x.IsActive).ToListAsync();
    //}

    //public async Task<ErrorOr<bool>> RemoveEventPictures(List<EventPicture> eventPictures)
    //{
    //    try
    //    {
    //        _eventContext.EventPictures.RemoveRange(eventPictures);

    //        await _eventContext.SaveChangesAsync();

    //        return true;
    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<ErrorOr<bool>> RemoveEvent(Domain.Events.Event ev) 
    //{
    //    try
    //    {
    //        _eventContext.Remove(ev);

    //        await _eventContext.SaveChangesAsync();

    //        return true;
    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<ErrorOr<bool>> UpdateEvent(Domain.Events.Event ev) 
    //{
    //    try
    //    {
    //        _eventContext.Events.Update(ev);

    //        await _eventContext.SaveChangesAsync();
    //        return true;
    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<Domain.Events.Event?> GetEventById(int eventId) 
    //{
    //    return await _eventContext.Events.SingleOrDefaultAsync(x=> x.EventId == eventId);
    //}

    //public async Task<ErrorOr<List<Domain.Events.Event>>> GetEvents(int[]? arr) 
    //{
    //    try
    //    {
    //        return await _eventContext.Events.Where(x => x.IsActive && x.EndDate > DateTime.Now && (arr.Length == 0  || arr.Contains(x.EventTypeId))).OrderBy(x => Guid.NewGuid()).Take(20).ToListAsync();

    //    }
    //    catch (Exception ex)
    //    {
    //        return Errors.Event.Unexpected;
    //    }
    //}

    //public async Task<bool> CheckEvent(int eventId) 
    //{
    //    return await _eventContext.Events.AnyAsync(x => x.EventId == eventId);
    //}

    //public async Task<string> GetEventTypeById(int eventTypeId) 
    //{
    //    var types = await _eventContext.EventTypes.SingleOrDefaultAsync(x => x.EventTypeId == eventTypeId);
    //    if (types is null) return string.Empty;
    //    return types.EventTypeName;
    //}

    //public async Task<List<Domain.Events.Event>> GetPaidEvents() 
    //{
    //    return await _eventContext.Events.Where(x => x.IsActive && x.EventStatusId == (int)EventStatusEnum.Paid && x.EndDate >= DateTime.Now).ToListAsync();
    //}
}
