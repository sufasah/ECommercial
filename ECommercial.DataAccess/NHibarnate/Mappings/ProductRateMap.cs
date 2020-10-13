using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class ProductRateMap : ClassMap<ProductRate>
    {
        public ProductRateMap()
        {
            Table(@"product_rates");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Comment).Column("comment");
            
            Map(x=>x.Datetime).Column("datetime");
            
            Map(x=>x.HidUserInfoEnabled).Column("hid_user_info_enabled");
            
            Map(x=>x.Images).Column("images");
            
            Map(x=>x.ProductId).Column("product_id");
            
            Map(x=>x.Rate).Column("rate");
            
            Map(x=>x.UserId).Column("user_id");
            
        }
    }
}