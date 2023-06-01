namespace Infrastructure.MesssageBroker;

public class MessageBrokerSettings
{
    public const string SectionName = "MessageBroker";

    public string Host { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
