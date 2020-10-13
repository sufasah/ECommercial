using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"products");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Expiry).Column("expiry");
            
            Map(x=>x.Name).Column("name");
            
            Map(x=>x.Properties).Column("properties");
            
            Map(x=>x.SubsubcategoryId).Column("subsubcategory_id");
            
            Map(x=>x.VatRate).Column("vat_rate");
            
            Map(x=>x.WarrantyPeriod).Column("warranty_period");
            
            Map(x=>x.WarrantyType).Column("warranty_type");
            
            Map(x=>x.Barcode).Column("barcode");
            
            Map(x=>x.BrandId).Column("brand_id");
            
            Map(x=>x.CargoCorporation).Column("cargo_corporation");
            
            Map(x=>x.Commission).Column("commission");
            
            Map(x=>x.Deci).Column("deci");
            
            Map(x=>x.Description).Column("description");
            
        }
    }
}