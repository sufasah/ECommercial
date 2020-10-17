using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserFavouriteProduct:IEntity
    {
        public UserFavouriteProduct()
        {
        }

        public UserFavouriteProduct(int ıd, int userId, int productId)
        {
            Id = ıd;
            UserId = userId;
            ProductId = productId;
        }

        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int ProductId { get; set; }
    }
}