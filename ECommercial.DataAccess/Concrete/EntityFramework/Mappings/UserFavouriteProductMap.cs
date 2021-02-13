using ECommercial.Entities.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class UserFavouriteProductMap : IEntityTypeConfiguration<UserFavouriteProduct>
    {
        public void Configure(EntityTypeBuilder<UserFavouriteProduct> builder)
        {
            builder.ToTable(@"user_favourite_products",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
        }
    }
}