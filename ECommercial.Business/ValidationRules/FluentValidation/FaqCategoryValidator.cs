using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class FaqCategoryValidator : AbstractValidator<FaqCategory>
    {
        public FaqCategoryValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .MaximumLength(50)
            .NotEmpty();

        }
        
    }
    
}