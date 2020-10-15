using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Coupon:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int Amount { get; set; }
    }
}