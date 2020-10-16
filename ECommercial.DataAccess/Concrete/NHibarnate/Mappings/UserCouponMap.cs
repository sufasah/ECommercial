using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class UserCouponMap : ClassMap<UserCoupon>
    {
        public UserCouponMap()
        {
            Table(@"user_coupons");
            Id(x=>x.Id).Column("id");
            
            Map(x=>x.CouponId).Column("coupon_id");
            
            Map(x=>x.UserId).Column("user_id");
            
        }
    }
}