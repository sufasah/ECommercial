using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class UserFavouriteProductValidator : AbstractValidator<UserFavouriteProduct>
    {
        public UserFavouriteProductValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}