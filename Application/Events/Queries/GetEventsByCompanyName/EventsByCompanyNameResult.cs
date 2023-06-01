namespace Application.Events.Queries.GetEventsByCompanyName;

public class EventsByCompanyNameResult
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int EventId { get; set; }
    public string Picture { get; set; } = null!;
    public string ScrollDescription { get; set; } = null!;
    public string? CompanyName { get; set; }
    public string Title { get; set; } = null!;
}
