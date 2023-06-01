

namespace Application.Events.Queries.GetFilteredEvents
{
    public class GetFilteredEventsResult
    {
        public string Key { get; set; } =  Guid.NewGuid().ToString();
        public int EventId { get; set; }
        public string Picture { get; set; } = null!;
        public string ScrollDescription { get; set; } = null!;
        public string? CompanyName { get; set; }
        public string Title { get; set; } = null!;
    }
}
