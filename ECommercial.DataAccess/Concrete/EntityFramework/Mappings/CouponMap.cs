using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class CouponMap : IEntityTypeConfiguration<Coupon>
    {
       
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable(@"coupons",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.Amount).HasColumnName("amount");
            
        }
    }
}