using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class OrderProductMap : IEntityTypeConfiguration<OrderProduct>
    {
     
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable(@"order_products",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.Count).HasColumnName("count");
            
            builder.Property(x=>x.OrderId).HasColumnName("order_id");
            
            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
            builder.Property(x=>x.State).HasColumnName("state");
            
        }
    }
}