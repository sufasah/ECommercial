using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class GeneralInfoValidator : AbstractValidator<GeneralInfo>
    {
        public GeneralInfoValidator()
        {
            RuleFor(x=>x.Key)
            .NotNull()
            .NotEmpty()
            .MaximumLength(30)
            ;

            RuleFor(x=>x.Value)
            .NotEmpty()
            .MaximumLength(200)
            ;

        }
        
    }
    
}