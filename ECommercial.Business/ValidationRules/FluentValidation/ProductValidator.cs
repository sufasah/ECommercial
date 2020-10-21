using System.Runtime.ConstrainedExecution;
using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.Id).PrimaryKeyIdRule();

            RuleFor(p=>p.Barcode)
            .GreaterThan(0)
            .NotNull();

            RuleFor(p=>p.BrandId).PrimaryKeyIdRule();

            RuleFor(p=>p.CargoCorporation)
            .MaximumLength(50)
            .NotNull();

            RuleFor(p=>p.Commission)
            .InclusiveBetween(0,100);

            RuleFor(p=>p.Deci)
            .NotNull()
            .GreaterThan((short)0);
            
            RuleFor(p=>p.Description)
            .NotEmpty();
            
            RuleFor(p=>p.Expiry)
            .NotNull();
            
            RuleFor(p=>p.Name)
            .NotNull()
            .MaximumLength(250);
            
            RuleFor(p=>p.Properties);
            
            RuleFor(p=>(int)p.SubsubcategoryId)
            .PrimaryKeyIdRule();

            RuleFor(p=>p.VatRate)
            .NotNull();

            RuleFor(p=>p.WarrantyPeriod);
            
            RuleFor(p=>p.WarrantyType)
            .NotNull();
            
            RuleFor(p=>(Enum)p.WarrantyType)
            .EnumValueMaximumLength(5);
                        
        }
        
    }
    
}