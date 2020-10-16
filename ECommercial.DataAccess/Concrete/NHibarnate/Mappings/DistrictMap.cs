using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class DistrictMap : ClassMap<District>
    {
        public DistrictMap()
        {
            Table(@"districts");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Name).Column("name");
            
            Map(x=>x.CityId).Column("city_id");
            
        }
    }
}