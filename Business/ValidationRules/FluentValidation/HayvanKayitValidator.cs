using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HayvanKayitValidator:AbstractValidator<HayvanKayit>
    {
        public HayvanKayitValidator()
        {
            RuleFor(h => h.Ad).MinimumLength(2);
            //notempty
            //greaterthan
            //RuleFor(h=>h.unitprice).GreaterThanOrEqualTo(10).when(h=>h.categoryıd==1)
            //RuleFor(h => h.Ad).Must(startwihtA).WithMessage("a ile başlamalı");
        }

        //private bool startwihtA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
