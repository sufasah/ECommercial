using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class InvoiceValidator : AbstractValidator<Invoice>
    {
        public InvoiceValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Address)
            .NotNull()
            .MaximumLength(250)
            .NotEmpty();
            
            RuleFor(x=>(int)x.CityId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.InvoiceeName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.InvoiceeNumber)
            .PhoneNumberRule()
            .NotNull();
            
            RuleFor(x=>x.InvoiceeSurname)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.Type);

            RuleFor(x=>(Enum)x.Type)
            .EnumValueMaximumLength(20);
            
            RuleFor(x=>(int)x.UserId);
            
        }
        
    }
    
}