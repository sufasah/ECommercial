using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class UserCouponMap : IEntityTypeConfiguration<UserCoupon>
    {
 
        public void Configure(EntityTypeBuilder<UserCoupon> builder)
        {
            builder.ToTable(@"user_coupons",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.CouponId).HasColumnName("coupon_id");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
        }
    }
}