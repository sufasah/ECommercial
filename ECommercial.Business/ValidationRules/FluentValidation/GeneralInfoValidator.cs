using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class GeneralInfoValidator : AbstractValidator<GeneralInfo>
    {
        public GeneralInfoValidator()
        {
            RuleFor(x=>x.Key)
            .NotNull()
            .MaximumLength(30)
            .NotEmpty();

            RuleFor(x=>x.Value)
            .MaximumLength(200)
            .NotEmpty();

        }
        
    }
    
}