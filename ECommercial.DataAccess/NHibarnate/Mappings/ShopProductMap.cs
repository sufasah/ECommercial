using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class ShopProductMap : ClassMap<ShopProduct>
    {
        public ShopProductMap()
        {
            Table(@"shop_products");
            Id(x=>x.Id).Column("id");
            
            Map(x=>x.DayForCargo).Column("day_for_cargo");
            
            Map(x=>x.Images).Column("images");
            
            Map(x=>x.Price).Column("price");
            
            Map(x=>x.ProductId).Column("product_id");
            
            Map(x=>x.ProductRating).Column("product_rating");
            
            Map(x=>x.RatingCount).Column("rating_count");
            
            Map(x=>x.ReleaseDatetime).Column("release_datetime");
            
            Map(x=>x.ShopId).Column("shop_id");
            
            Map(x=>x.State).Column("state");
            
            Map(x=>x.StockAmount).Column("stock_amount");
            
            Map(x=>x.StockCode).Column("stock_code");
            
            Map(x=>x.VariantGroupId).Column("variant_group_id");
        }
    }
}