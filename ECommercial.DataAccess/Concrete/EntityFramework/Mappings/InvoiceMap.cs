using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class InvoiceMap : IEntityTypeConfiguration<Invoice>
    {
     

        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable(@"invoices",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();

            builder.Property(x=>x.CityId).HasColumnName("city_id");
            
            builder.Property(x=>x.InvoiceeName).HasColumnName("invoicee_name");
            
            builder.Property(x=>x.InvoiceeNumber).HasColumnName("invoicee_number");
            
            builder.Property(x=>x.InvoiceeSurname).HasColumnName("invoicee_surname");
            
            builder.Property(x=>x.Type).HasColumnName("type").HasConversion(new EnumToStringConverter<Invoice.Types>());
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
            builder.Property(x=>x.Address).HasColumnName("address");
            
        }
    }
}