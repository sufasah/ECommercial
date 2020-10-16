using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class CampaignMap : ClassMap<Campaign>
    {
        public CampaignMap()
        {
            Table(@"campaigns");

            Id(x=>x.Id).Column("id");

            Map(x=>x.Rate).Column("rate");

            Map(x=>x.StartDateTime).Column("start_datetime");

            Map(x=>x.EndDateTime).Column("end_datetime");
            
        }
    }
}