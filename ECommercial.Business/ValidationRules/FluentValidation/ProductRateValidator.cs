using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class ProductRateValidator : AbstractValidator<ProductRate>
    {
        public ProductRateValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.Comment)
            .NotEmpty()
            .MaximumLength(3000);

            RuleFor(x=>x.Datetime)
            .NotNull();
            
            RuleFor(x=>x.HidUserInfoEnabled)
            .NotNull();
            
            RuleFor(x=>x.Images)
            .NotEmpty();
            
            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.Rate)
            .NotNull();
            
            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}