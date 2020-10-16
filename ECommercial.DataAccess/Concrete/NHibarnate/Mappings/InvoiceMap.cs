using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class InvoiceMap : ClassMap<Invoice>
    {
        public InvoiceMap()
        {
            Table(@"invoices");
            Id(x=>x.Id).Column("id");
            
            Map(x=>x.CityId).Column("city_id");
            
            Map(x=>x.InvoiceeName).Column("invoicee_name");
            
            Map(x=>x.InvoiceeNumber).Column("invoicee_number");
            
            Map(x=>x.InvoiceeSurname).Column("invoicee_surname");

            Map(x=>x.Type).Column("type");
            
            Map(x=>x.UserId).Column("user_id");
            
            Map(x=>x.Address).Column("address");
            
        }
    }
}