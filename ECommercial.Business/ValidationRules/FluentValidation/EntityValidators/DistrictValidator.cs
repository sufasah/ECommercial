using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(x=>(int?)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty();

            RuleFor(x=>(int?)x.CityId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}