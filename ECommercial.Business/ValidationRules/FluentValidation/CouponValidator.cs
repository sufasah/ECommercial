using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class CouponValidator : AbstractValidator<Coupon>
    {
        public CouponValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Amount)
            .NotNull()
            .GreaterThan(0);

        }
        
    }
    
}