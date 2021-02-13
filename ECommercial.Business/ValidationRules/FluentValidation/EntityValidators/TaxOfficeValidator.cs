using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class TaxOfficeValidator : AbstractValidator<TaxOffice>
    {
        public TaxOfficeValidator()
        {
            RuleFor(x=>(int?)x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Name)
            .NotEmpty()
            .NotNull();

            RuleFor(x=>x.AccountingUnitCode);
            
            RuleFor(x=>(int?)x.CityId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>(int?)x.DistrictId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}