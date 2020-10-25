using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class ProductRateMap : IEntityTypeConfiguration<ProductRate>
    {
 
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.ToTable(@"product_rates",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.Comment).HasColumnName("comment");
            
            builder.Property(x=>x.Datetime).HasColumnName("datetime");
            
            builder.Property(x=>x.HidUserInfoEnabled).HasColumnName("hid_user_info_enabled");
            
            builder.Property(x=>x.Images).HasColumnName("images");
            
            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
            builder.Property(x=>x.Rate).HasColumnName("rate");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            

        }
    }
}