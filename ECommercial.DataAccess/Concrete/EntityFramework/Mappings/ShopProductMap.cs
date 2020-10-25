using ECommercial.Entites.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class ShopProductMap : IEntityTypeConfiguration<ShopProduct>
    {

        public void Configure(EntityTypeBuilder<ShopProduct> builder)
        {
            builder.ToTable(@"shop_products",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.DayForCargo).HasColumnName("day_for_cargo");
            
            builder.Property(x=>x.Images).HasColumnName("images");
            
            builder.Property(x=>x.Price).HasColumnName("price");
            
            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
            builder.Property(x=>x.ProductRating).HasColumnName("product_rating");
            
            builder.Property(x=>x.RatingCount).HasColumnName("rating_count");
            
            builder.Property(x=>x.ReleaseDatetime).HasColumnName("release_datetime");
            
            builder.Property(x=>x.ShopId).HasColumnName("shop_id");
            
            builder.Property(x=>x.State).HasColumnName("state").HasConversion(new EnumToStringConverter<ShopProduct.States>());
            
            builder.Property(x=>x.StockAmount).HasColumnName("stock_amount");
            
            builder.Property(x=>x.StockCode).HasColumnName("stock_code");
            
            builder.Property(x=>x.VariantGroupId).HasColumnName("variant_group_id");
        }
    }
}