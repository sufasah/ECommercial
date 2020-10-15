using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class OrderProduct:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int OrderId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Count { get; set; }
        public virtual int State { get; set; }
    }
}