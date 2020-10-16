using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class TaxOfficeMap : ClassMap<TaxOffice>
    {
        public TaxOfficeMap()
        {
            Table(@"tax_offices");
            Id(x=>x.Id).Column("id");

            Map(x=>x.AccountingUnitCode).Column("accounting_unit_code");
            
            Map(x=>x.CityId).Column("city_id");
            
            Map(x=>x.DistrictId).Column("district_id");
            
            Map(x=>x.Name).Column("name");
            
        }
    }
}