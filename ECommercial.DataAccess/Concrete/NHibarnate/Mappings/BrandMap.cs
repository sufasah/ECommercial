using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class BrandMap : ClassMap<Brand>
    {
        public BrandMap()
        {
            Table(@"brands");

            Id(x=>x.Id);

            Map(x=>x.brand).Column("brand");

        }
    }
}