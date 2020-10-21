using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
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