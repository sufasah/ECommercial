using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class UserFavouriteProductMap : ClassMap<UserFavouriteProduct>
    {
        public UserFavouriteProductMap()
        {
            Table(@"user_favourite_products");
            Id(x=>x.Id).Column("id");

            Map(x=>x.ProductId).Column("product_id");
            
            Map(x=>x.UserId).Column("user_id");
            
        }
    }
}