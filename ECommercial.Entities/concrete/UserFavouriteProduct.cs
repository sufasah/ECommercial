using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserFavouriteProduct:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}