using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetFilteredEvents
{
    public class GetFilteredEventsQueryValidator : AbstractValidator<GetFilteredEventsQuery>
    {
        public GetFilteredEventsQueryValidator() 
        {

        }
    }
}
