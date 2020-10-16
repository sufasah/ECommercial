using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class CouponMap : ClassMap<Coupon>
    {
        public CouponMap()
        {
            Table(@"coupons");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Amount).Column("amount");
            
        }
    }
}