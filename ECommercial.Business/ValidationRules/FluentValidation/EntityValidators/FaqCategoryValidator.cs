using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class FaqCategoryValidator : AbstractValidator<FaqCategory>
    {
        public FaqCategoryValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .MaximumLength(50)
            .NotEmpty();

        }
        
    }
    
}