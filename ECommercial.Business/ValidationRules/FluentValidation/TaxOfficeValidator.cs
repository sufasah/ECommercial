using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class TaxOfficeValidator : AbstractValidator<TaxOffice>
    {
        public TaxOfficeValidator()
        {
            RuleFor(x=>(int)x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Name)
            .NotEmpty()
            .NotNull();

            RuleFor(x=>x.AccountingUnitCode);
            
            RuleFor(x=>(int)x.CityId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>(int)x.DistrictId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}