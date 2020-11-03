using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class LogValidator : AbstractValidator<Log>
    {
        public LogValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Audit)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50)
            ;

            RuleFor(x=>x.Date)
            .NotNull()
            ;
            
            RuleFor(x=>x.Detail)
            .NotNull();
            

        }
        
    }
    
}