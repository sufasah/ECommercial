using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class ShopMap : ClassMap<Shop>
    {
        public ShopMap()
        {
            Table(@"shops");
            Id(x=>x.Id).Column("id");

            Map(x=>x.AccountNumber).Column("account_number");
            
            Map(x=>x.AuthorizedEmail).Column("authorized_email");
            
            Map(x=>x.AuthorizedGender).Column("authorized_gender");
            
            Map(x=>x.AuthorizedName).Column("authorized_name");
            
            Map(x=>x.AuthorizedPhone).Column("authorized_phone");
            
            Map(x=>x.AuthorizedPosition).Column("authorized_position");
            
            Map(x=>x.AuthorizedSurname).Column("authorized_surname");
            
            Map(x=>x.BankAccountOwner).Column("bank_account_owner");
            
            Map(x=>x.BankId).Column("bank_id");
            
            Map(x=>x.BranchBankName).Column("branch_bank_name");
            
            Map(x=>x.BranchCode).Column("branch_code");
            
            Map(x=>x.CommercialRecordNumber).Column("commercial_record_number");
            
            Map(x=>x.FirmEmail).Column("firm_email");
            
            Map(x=>x.FirmFixedPhone).Column("firm_fixed_phone");
            
            Map(x=>x.FirmOwnerName).Column("firm_owner_name");
            
            Map(x=>x.FirmOwnerSurname).Column("firm_owner_surname");
            
            Map(x=>x.FirmProfile).Column("firm_profile");
            
            Map(x=>x.FirmType).Column("firm_type");
            
            Map(x=>x.FirmWebsite).Column("firm_website");
            
            Map(x=>x.FırmOwnerPhone).Column("firm_owner_phone");
            
            Map(x=>x.Iban).Column("iban");
            
            Map(x=>x.InvoiceAddress).Column("invoice_address");

            Map(x=>x.InvoiceCityId).Column("invoice_city_id");
            
            Map(x=>x.InvoiceDistrictId).Column("invoice_district_id");
            
            Map(x=>x.InvoiceEmail).Column("invoice_email");
            
            Map(x=>x.KepMail).Column("kep_mail");
            
            Map(x=>x.LegalFirmName).Column("legal_firm_name");
            
            Map(x=>x.MersisNumber).Column("mersis_number");
            
            Map(x=>x.Password).Column("password");
            
            Map(x=>x.SellingSubcategoryId).Column("selling_subcategory_id");
            
            Map(x=>x.ShopOwnerName).Column("shop_owner_name");
            
            Map(x=>x.TaxOfficeCityId).Column("tax_office_city_id");
            
            Map(x=>x.TaxOfficeId).Column("tax_office_id");
            
            Map(x=>x.TaxOrTrIdNumber).Column("tax_or_trid_number");
            
            Map(x=>x.Username).Column("username");
        }
    }
}