using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x=>x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.UserShopId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.ReceiverNumber)
            .NotNull()
            .PhoneNumberRule();
            
            RuleFor(x=>x.ReceiverSurname)
            .MaximumLength(40)
            .NotEmpty();
            
            RuleFor(x=>x.UserShopId)
            .PrimaryKeyIdRule();
        }
        
    }
    
}