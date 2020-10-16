using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class ProductCampaignMap : ClassMap<ProductCampaign>
    {
        public ProductCampaignMap()
        {
            Table(@"product_campaigns");
            Id(x=>x.Id).Column("id");

            Map(x=>x.CampaignId).Column("campaign_id");

            Map(x=>x.ProductId).Column("product_id");
            
            
        }
    }
}