namespace Application.Common.Interfaces.Services;

public interface IEventBus
{
    Task PublishAsync<T>(T message, Uri uri, CancellationToken cancellationToken = default(CancellationToken)) where T : class;
}
