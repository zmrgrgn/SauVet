using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HayvanTurValidator:AbstractValidator<HayvanTur>
    {
        public HayvanTurValidator()
        {
            RuleFor(h => h.HayvanTurAd).MinimumLength(2);
        }
    }
}
