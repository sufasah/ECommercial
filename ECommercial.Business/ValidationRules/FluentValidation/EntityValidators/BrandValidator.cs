using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.brand)
            .NotNull()
            .NotEmpty()
            .MaximumLength(200)
            ;

        }
        
    }
    
}