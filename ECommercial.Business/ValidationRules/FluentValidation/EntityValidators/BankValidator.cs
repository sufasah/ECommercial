using ECommercial.Entities.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(x=>(int?)x.Id)
            .PrimaryKeyIdRule();

            RuleFor(x=>x.Address)
            .NotEmpty()
            .MaximumLength(255);

            RuleFor(x=>x.Eft)
            .NotEmpty()
            .MaximumLength(4)
            ;
            
            RuleFor(x=>x.Fax)
            .NotEmpty()
            .MaximumLength(16)
            ;
            
            RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(128)
            ;
            
            RuleFor(x=>x.Swift)
            .NotEmpty()
            .MaximumLength(16)
            ;
            
            RuleFor(x=>x.Telephone)
            .NotEmpty()
            .MaximumLength(16)
            ;
            
            RuleFor(x=>x.Telex)
            .NotEmpty()
            .MaximumLength(32)
            ;
            
            RuleFor(x=>x.Web)
            .NotEmpty()
            .MaximumLength(64)
            ;
                        
        }
        
    }
    
}