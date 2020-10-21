using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class UserCouponValidator : AbstractValidator<UserCoupon>
    {
        public UserCouponValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.CouponId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}