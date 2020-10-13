using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class GeneralInfoMap : ClassMap<GeneralInfo>
    {
        public GeneralInfoMap()
        {
            Table(@"general_infos");
            Id(x=>x.Key).Column("key");
            Map(x=>x.Value).Column("value");
            
        }
    }
}