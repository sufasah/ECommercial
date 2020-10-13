using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class OrderProductMap : ClassMap<OrderProduct>
    {
        public OrderProductMap()
        {
            Table(@"order_products");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Count).Column("count");
            
            Map(x=>x.OrderId).Column("order_id");
            
            Map(x=>x.ProductId).Column("product_id");
            
            Map(x=>x.State).Column("state");
            
        }
    }
}