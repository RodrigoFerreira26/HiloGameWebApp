using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetPlayHistory
{
    public class GetPlayHistoryValidator : AbstractValidator<GetPlayHistoryQuery>
    {
        public GetPlayHistoryValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id must be greater than 0");
        }
    }
}
