using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserCoupon:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int CouponId { get; set; }
        public virtual int UserId { get; set; }
    }
}