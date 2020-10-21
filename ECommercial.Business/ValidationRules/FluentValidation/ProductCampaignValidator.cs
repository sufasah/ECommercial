using System;
using System.ComponentModel.DataAnnotations;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation
{
    public class ProductCampaignValidator : AbstractValidator<ProductCampaign>
    {
        public ProductCampaignValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.CampaignId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.ProductId)
            .PrimaryKeyIdRule();
            
        }
        
    }
    
}