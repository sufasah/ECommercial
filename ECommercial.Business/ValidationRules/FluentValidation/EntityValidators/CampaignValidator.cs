using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class CampaignValidator : AbstractValidator<Campaign>
    {
        public CampaignValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.EndDateTime)
            .NotNull();

            RuleFor(x=>x.Rate)
            .NotNull();
            
            RuleFor(x=>x.StartDateTime)
            .NotNull();
            
        }
        
    }
    
}