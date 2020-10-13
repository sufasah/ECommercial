using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Table(@"orders");
            Id(x=>x.Id).Column("id");

            Map(x=>x.ClaimAddressId).Column("claim_address_id");

            Map(x=>x.Datetime).Column("datetime");
            
            Map(x=>x.InvoiceId).Column("invoice_id");
            
            Map(x=>x.UserId).Column("user_id");
            
        }
    }
}