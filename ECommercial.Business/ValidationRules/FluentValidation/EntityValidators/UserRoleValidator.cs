using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class UserRoleValidator : AbstractValidator<UserRole>
    {
        public UserRoleValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.RoleId)
            .PrimaryKeyIdRule()
            ;

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule()
            ;
                       
        }
        
    }
    
}