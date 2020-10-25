using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x=>(int?)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty();

        }
        
    }
    
}