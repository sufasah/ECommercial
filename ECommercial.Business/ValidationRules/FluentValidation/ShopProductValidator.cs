using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class ShopProductValidator : AbstractValidator<ShopProduct>
    {
        public ShopProductValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.DayForCargo)
            .NotNull();

            RuleFor(x=>x.Images);
            
            RuleFor(x=>x.Price)
            .NotNull();
            
            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.ProductRating);
            
            RuleFor(x=>x.RatingCount);
            
            RuleFor(x=>x.ReleaseDatetime)
            .NotNull();
            
            RuleFor(x=>x.ShopId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.State);
            RuleFor(x=>(Enum)x.State)
            .EnumValueMaximumLength(20);
            
            RuleFor(x=>x.StockAmount);
            
            RuleFor(x=>x.StockCode)
            .NotEmpty()
            .MaximumLength(10);
            
            RuleFor(x=>x.VariantGroupId);
            
        }
        
    }
    
}