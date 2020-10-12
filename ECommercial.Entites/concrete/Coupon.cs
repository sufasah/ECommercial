using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Coupon:IEntity
    {
        public int Id { get; set; }
        public int Amount { get; set; }
    }
}