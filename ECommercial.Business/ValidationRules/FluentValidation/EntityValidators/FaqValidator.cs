using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class FaqValidator : AbstractValidator<Faq>
    {
        public FaqValidator()
        {
            RuleFor(x=>(int?)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50)
            ;

            RuleFor(x=>(int?)x.FaqSubcategoryId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.Content)
            .NotNull()
            .MaximumLength(5000);
            
        }
        
    }
    
}