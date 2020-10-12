using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class OrderProduct:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public int State { get; set; }
    }
}