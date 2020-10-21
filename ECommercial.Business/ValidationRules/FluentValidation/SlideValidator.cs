using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class SlideValidator : AbstractValidator<Slide>
    {
        public SlideValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.ImageUrl)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);
            
            RuleFor(x=>x.RouteUrl)
            .NotEmpty()
            .MaximumLength(250);
            
            RuleFor(x=>x.SlideOrder);

        }
        
    }
    
}