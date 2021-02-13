using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class UserProductWillBeOrderedValidator : AbstractValidator<UserProductWillBeOrdered>
    {
        public UserProductWillBeOrderedValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}