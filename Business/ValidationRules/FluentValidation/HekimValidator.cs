using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HekimValidator : AbstractValidator<Hekim>
    {
        public HekimValidator()
        {
            RuleFor(h => h.Ad).MinimumLength(2);
        }
    }
}
