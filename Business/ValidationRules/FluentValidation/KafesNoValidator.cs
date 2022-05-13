using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class KafesNoValidator:AbstractValidator<KafesNo>
    {
        public KafesNoValidator()
        {
            RuleFor(k => k.KafesAdi).MinimumLength(2);
        }
    }
}
