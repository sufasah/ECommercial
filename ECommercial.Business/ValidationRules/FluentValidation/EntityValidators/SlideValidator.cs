using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class SlideValidator : AbstractValidator<Slide>
    {
        public SlideValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.ImageUrl)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);
            
            RuleFor(x=>x.RouteUrl)
            .NotEmpty()
            .MaximumLength(250);
            
            RuleFor(x=>x.SlideOrder);

        }
        
    }
    
}