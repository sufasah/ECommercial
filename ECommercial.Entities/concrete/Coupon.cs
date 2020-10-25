using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Coupon:IEntity
    {
        public Coupon()
        {
        }

        public Coupon(int? ıd, int? amount)
        {
            Id = ıd;
            Amount = amount;
        }

        public virtual int? Id { get; set; }
        public virtual int? Amount { get; set; }
    }
}