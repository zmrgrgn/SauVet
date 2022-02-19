using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MamaValidator : AbstractValidator<Mama>
    {
        public MamaValidator()
        {
            RuleFor(m => m.Ad).MinimumLength(2);
        }
    }
}
