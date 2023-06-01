namespace Infrastructure.Services;

public sealed class EventBus : IEventBus
{

    private readonly IBus _bus;

    public EventBus(IBus bus)
    {
        _bus = bus;
    }

    public async Task PublishAsync<T>(T message, Uri uri, CancellationToken cancellationToken = default)
        where T : class =>
        await (await _bus.GetSendEndpoint(uri)).Send(message, cancellationToken);
}
