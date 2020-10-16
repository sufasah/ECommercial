using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class TaxOfficeMap : IEntityTypeConfiguration<TaxOffice>
    {

        public void Configure(EntityTypeBuilder<TaxOffice> builder)
        {
            builder.ToTable(@"tax_offices",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.AccountingUnitCode).HasColumnName("accounting_unit_code");
            
            builder.Property(x=>x.CityId).HasColumnName("city_id");
            
            builder.Property(x=>x.DistrictId).HasColumnName("district_id");
            
            builder.Property(x=>x.Name).HasColumnName("name");
            
        }
    }
}