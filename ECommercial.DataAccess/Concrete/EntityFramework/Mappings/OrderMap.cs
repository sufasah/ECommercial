using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
    

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(@"orders",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.ClaimAddressId).HasColumnName("claim_address_id");
            
            builder.Property(x=>x.Datetime).HasColumnName("datetime");
            
            builder.Property(x=>x.InvoiceId).HasColumnName("invoice_id");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
        }
    }
}