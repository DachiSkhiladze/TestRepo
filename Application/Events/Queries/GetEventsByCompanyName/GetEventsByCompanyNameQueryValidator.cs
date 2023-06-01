using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetEventsByCompanyName
{
    public class GetEventsByCompanyNameQueryValidator : AbstractValidator<GetEventsByCompanyNameQuery>
    {
        public GetEventsByCompanyNameQueryValidator() 
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
