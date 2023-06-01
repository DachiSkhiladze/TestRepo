namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsResult
    {
        public int EventId { get; set; }
        public string EventType { get; set; } = null!;
        public string EventNameEng { get; set; } = null!;
        public string DescriptionEng { get; set; } = null!;
        public string ScrollDescriptionEng { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Stars { get; set; }
        public decimal Price { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public int DurationInMinutes { get; set; }
        public string Address { get; set; } = null!;
        public List<string> Pictures { get; set; } = null!;
    }
}
