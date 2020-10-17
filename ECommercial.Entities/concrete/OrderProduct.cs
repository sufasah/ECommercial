using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class OrderProduct:IEntity
    {
        public OrderProduct()
        {
        }

        public OrderProduct(int ıd, int orderId, int productId, int count, int state)
        {
            Id = ıd;
            OrderId = orderId;
            ProductId = productId;
            Count = count;
            State = state;
        }

        public virtual int Id { get; set; }
        public virtual int OrderId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Count { get; set; }
        public virtual int State { get; set; }
    }
}