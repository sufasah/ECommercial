using System;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public class ShopValidator : AbstractValidator<Shop>
    {
        public ShopValidator()
        {
            RuleFor(x=>x.Id).PrimaryKeyIdRule();

            RuleFor(x=>x.AccountNumber)
            .NotNull();
            
            RuleFor(x=>x.AuthorizedEmail)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.AuthorizedGender)
            .NotNull();
            
            RuleFor(x=>x.AuthorizedName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.AuthorizedPhone)
            .PhoneNumberRule()
            .NotNull();
            
            RuleFor(x=>x.AuthorizedPosition)
            .NotNull()
            .NotEmpty()
            .MaximumLength(30);
            
            RuleFor(x=>x.AuthorizedSurname)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>x.BankAccountOwner)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>(int)x.BankId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.BranchBankName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(128);
            
            RuleFor(x=>x.BranchCode)
            .NotNull();
            
            RuleFor(x=>x.CommercialRecordNumber);
            
            RuleFor(x=>x.FirmEmail)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.FirmFixedPhone)
            .NotNull()
            .PhoneNumberRule();
            
            RuleFor(x=>x.FirmOwnerName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(20);
            
            RuleFor(x=>x.FirmOwnerSurname)
            .NotNull()
            .NotEmpty()
            .MaximumLength(20);
            
            RuleFor(x=>(Enum)x.FirmProfile)
            .EnumValueMaximumLength(20);
            
            RuleFor(x=>(Enum)x.FirmType)
            .EnumValueMaximumLength(30);
            
            RuleFor(x=>x.FirmWebsite)
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.FırmOwnerPhone)
            .PhoneNumberRule()
            .NotNull();
            
            RuleFor(x=>x.Iban)
            .NotNull();
            
            RuleFor(x=>x.InvoiceAddress)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);
            
            RuleFor(x=>(int)x.InvoiceCityId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>(int)x.InvoiceDistrictId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.InvoiceEmail)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.KepMail)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.LegalFirmName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
            
            RuleFor(x=>x.MersisNumber)
            .NotNull();
            
            RuleFor(x=>x.Password)
            .NotNull()
            .MinimumLength(8)
            .MaximumLength(16);
            
            RuleFor(x=>(int)x.SellingSubcategoryId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.ShopOwnerName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(40);
            
            RuleFor(x=>(int)x.TaxOfficeCityId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>(int)x.TaxOfficeId)
            .PrimaryKeyIdRule();
            
            RuleFor(x=>x.TaxOrTrIdNumber)
            .NotNull();
            
            RuleFor(x=>x.Username)
            .NotNull()
            .NotEmpty()
            .MaximumLength(30);
            
        }
        
    }
    
}