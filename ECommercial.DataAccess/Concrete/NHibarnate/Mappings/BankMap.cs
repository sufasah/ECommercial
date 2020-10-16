using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class BankMap:ClassMap<Bank>
    {
        public BankMap()
        {
            Table(@"banks");
            
            Id(x=>x.Id).Column("id");

            Map(x=>x.Eft).Column("eft");

            Map(x=>x.Fax).Column("fax");

            Map(x=>x.Name).Column("name");

            Map(x=>x.Swift).Column("swift");
            
            Map(x=>x.Telephone).Column("telephone");

            Map(x=>x.Telex).Column("telex");

            Map(x=>x.Web).Column("web");

            Map(x=>x.Address).Column("address");
            
        }
    }
}