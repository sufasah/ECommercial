using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class SubSubCategoryValidator : AbstractValidator<SubSubCategory>
    {
        public SubSubCategoryValidator()
        {
            RuleFor(x=>(int)x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);

            RuleFor(x=>(int)x.SubCategoryId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}