using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Table(@"cities");
            
            Id(x=>x.Id).Column("id");

            Map(x=>x.Name).Column("name");
            
        }
    }
}