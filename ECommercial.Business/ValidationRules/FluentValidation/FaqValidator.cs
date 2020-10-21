using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class FaqValidator : AbstractValidator<Faq>
    {
        public FaqValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .MaximumLength(50)
            .NotEmpty();

            RuleFor(x=>(int)x.FaqSubcategoryId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.Content)
            .NotNull()
            .MaximumLength(5000);
            
        }
        
    }
    
}