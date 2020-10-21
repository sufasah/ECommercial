using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class SubCategoryValidator : AbstractValidator<SubCategory>
    {
        public SubCategoryValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);

            RuleFor(x=>(int)x.CategoryId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}