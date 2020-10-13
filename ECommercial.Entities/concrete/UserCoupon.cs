using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserCoupon:IEntity
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int UserId { get; set; }
    }
}