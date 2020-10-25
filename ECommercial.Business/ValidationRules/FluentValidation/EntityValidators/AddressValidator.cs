using System.Data;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
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
            
            RuleFor(x=>(int?)x.CityId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.ReceiverSurname)
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.address)
            .NotNull()
            .MaximumLength(250);

            RuleFor(x=>x.ReceiverName)
            .NotNull()
            .MaximumLength(40);
        }
        
    }
    
}