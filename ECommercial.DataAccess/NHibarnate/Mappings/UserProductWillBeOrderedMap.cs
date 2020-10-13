using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class UserProductWillBeOrderedMap : ClassMap<UserProductWillBeOrdered>
    {
        public UserProductWillBeOrderedMap()
        {
            Table(@"user_products_will_be_ordered");
            Id(x=>x.Id).Column("id");

            Map(x=>x.ProductId).Column("product_id");
            
            Map(x=>x.UserId).Column("user_id");
            
        }
    }
}