using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserFavouriteProduct:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int ProductId { get; set; }
    }
}