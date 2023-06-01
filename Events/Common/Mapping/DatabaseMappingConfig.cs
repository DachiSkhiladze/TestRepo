namespace Events.Common.Mapping;

public class DatabaseMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateDatabaseRequest, CreateDatabaseCommand>();
    }
}
