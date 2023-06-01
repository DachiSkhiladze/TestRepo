namespace Events.Common.Mapping;

public class EventsMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<EventRegisterRequest, EventRegisterCommand>()
            .Map(dest => dest.Pictures, src => src.Pictures.ToList());
    }
}
