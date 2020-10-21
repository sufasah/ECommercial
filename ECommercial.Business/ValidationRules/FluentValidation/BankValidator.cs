using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Address)
            .MaximumLength(255)
            .NotEmpty();

            RuleFor(x=>x.Eft)
            .MaximumLength(4)
            .NotEmpty();
            
            RuleFor(x=>x.Fax)
            .MaximumLength(16)
            .NotEmpty();
            
            RuleFor(x=>x.Name)
            .NotNull()
            .MaximumLength(128)
            .NotEmpty();
            
            RuleFor(x=>x.Swift)
            .MaximumLength(16)
            .NotEmpty();
            
            RuleFor(x=>x.Telephone)
            .MaximumLength(16)
            .NotEmpty();
            
            RuleFor(x=>x.Telex)
            .MaximumLength(32)
            .NotEmpty();
            
            RuleFor(x=>x.Web)
            .MaximumLength(64)
            .NotEmpty();
                        
        }
        
    }
    
}