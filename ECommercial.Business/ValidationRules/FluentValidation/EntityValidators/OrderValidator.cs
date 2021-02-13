using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x=>x.Id)
            .NotNull();

            RuleFor(x=>x.ClaimAddressId)
            .NotNull();

            RuleFor(x=>x.Datetime)
            .NotNull();

            RuleFor(x=>x.InvoiceId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();

        }
        
    }
    
}