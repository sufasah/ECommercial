using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserCoupon:IEntity
    {
        public UserCoupon()
        {
        }

        public UserCoupon(int ıd, int couponId, int userId)
        {
            Id = ıd;
            CouponId = couponId;
            UserId = userId;
        }

        public virtual int Id { get; set; }
        public virtual int CouponId { get; set; }
        public virtual int UserId { get; set; }
    }
}