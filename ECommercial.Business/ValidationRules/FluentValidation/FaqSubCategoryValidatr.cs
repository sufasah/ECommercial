using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class FaqSubCategoryValidator : AbstractValidator<FaqSubCategory>
    {
        public FaqSubCategoryValidator()
        {
            RuleFor(x=>(int)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Title)
            .NotNull()
            .MaximumLength(100)
            .NotEmpty();

            RuleFor(x=>(int)x.FaqCategoryId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}