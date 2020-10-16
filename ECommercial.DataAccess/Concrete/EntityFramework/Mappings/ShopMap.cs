using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class ShopMap : IEntityTypeConfiguration<Shop>
    {
        

        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable(@"shops",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");
            
            builder.Property(x=>x.AccountNumber).HasColumnName("account_number");
            
            builder.Property(x=>x.AuthorizedEmail).HasColumnName("authorized_email");
            
            builder.Property(x=>x.AuthorizedGender).HasColumnName("authorized_gender");
            
            builder.Property(x=>x.AuthorizedName).HasColumnName("authorized_name");
            
            builder.Property(x=>x.AuthorizedPhone).HasColumnName("authorized_phone");
            
            builder.Property(x=>x.AuthorizedPosition).HasColumnName("authorized_position");
            
            builder.Property(x=>x.AuthorizedSurname).HasColumnName("authorized_surname");
            
            builder.Property(x=>x.BankAccountOwner).HasColumnName("bank_account_owner");
            
            builder.Property(x=>x.BankId).HasColumnName("bank_id");
            
            builder.Property(x=>x.BranchBankName).HasColumnName("branch_bank_name");
            
            builder.Property(x=>x.BranchCode).HasColumnName("branch_code");
            
            builder.Property(x=>x.CommercialRecordNumber).HasColumnName("commercial_record_number");
            
            builder.Property(x=>x.FirmEmail).HasColumnName("firm_email");
            
            builder.Property(x=>x.FirmFixedPhone).HasColumnName("firm_fixed_phone");
            
            builder.Property(x=>x.FirmOwnerName).HasColumnName("firm_owner_name");
            
            builder.Property(x=>x.FirmOwnerSurname).HasColumnName("firm_owner_surname");
            
            builder.Property(x=>x.FirmProfile).HasColumnName("firm_profile");
            
            builder.Property(x=>x.FirmType).HasColumnName("firm_type");
            
            builder.Property(x=>x.FirmWebsite).HasColumnName("firm_website");
            
            builder.Property(x=>x.FırmOwnerPhone).HasColumnName("firm_owner_phone");
            
            builder.Property(x=>x.Iban).HasColumnName("iban");
            
            builder.Property(x=>x.InvoiceAddress).HasColumnName("invoice_address");

            builder.Property(x=>x.InvoiceCityId).HasColumnName("invoice_city_id");
            
            builder.Property(x=>x.InvoiceDistrictId).HasColumnName("invoice_district_id");
            
            builder.Property(x=>x.InvoiceEmail).HasColumnName("invoice_email");
            
            builder.Property(x=>x.KepMail).HasColumnName("kep_mail");
            
            builder.Property(x=>x.LegalFirmName).HasColumnName("legal_firm_name");
            
            builder.Property(x=>x.MersisNumber).HasColumnName("mersis_number");
            
            builder.Property(x=>x.Password).HasColumnName("password");
            
            builder.Property(x=>x.SellingSubcategoryId).HasColumnName("selling_subcategory_id");
            
            builder.Property(x=>x.ShopOwnerName).HasColumnName("shop_owner_name");
            
            builder.Property(x=>x.TaxOfficeCıtyId).HasColumnName("tax_office_city_id");
            
            builder.Property(x=>x.TaxOfficeId).HasColumnName("tax_office_id");
            
            builder.Property(x=>x.TaxOrTrIdNumber).HasColumnName("tax_or_trid_number");
            
            builder.Property(x=>x.Username).HasColumnName("username");
        }
    }
}