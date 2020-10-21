using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.BirthDate)
            .NotNull();

            RuleFor(x=>x.Email)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.EmailNotificationEnabled)
            .NotNull();
            
            RuleFor(x=>x.Gender)
            .NotNull();
            
            RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.Phone)
            .NotNull()
            .PhoneNumberRule();
            
            RuleFor(x=>x.SmsNotificationEnabled)
            .NotNull();
            
            RuleFor(x=>x.Surname)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
        }
        
    }
    
}