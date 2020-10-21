using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class UserProductWillBeOrderedValidator : AbstractValidator<UserProductWillBeOrdered>
    {
        public UserProductWillBeOrderedValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.UserId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}