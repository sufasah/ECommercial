using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class OrderProductValidator : AbstractValidator<OrderProduct>
    {
        public OrderProductValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Count)
            .NotNull();

            RuleFor(x=>x.OrderId)
            .NotNull();
            
            RuleFor(x=>x.ProductId)
            .NotNull();
            
            RuleFor(x=>x.State)
            .NotNull();
            
            RuleFor(x=>(Enum)x.State)
            .EnumValueMaximumLength(30);
            
        }
        
    }
    
}