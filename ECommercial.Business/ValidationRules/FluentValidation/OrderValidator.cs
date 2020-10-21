using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
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