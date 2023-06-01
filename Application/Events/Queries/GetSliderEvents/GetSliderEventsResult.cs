using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetSliderEvents
{
    public class GetSliderEventsResult
    {
        public int EventId { get; set; }
        public string Title { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Picture { get; set; } = null!;
    }
}
