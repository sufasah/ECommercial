using ECommercial.Entities.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class TaxOfficeMap : IEntityTypeConfiguration<TaxOffice>
    {

        public void Configure(EntityTypeBuilder<TaxOffice> builder)
        {
            builder.ToTable(@"tax_offices",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<short?>();

            builder.Property(x=>x.AccountingUnitCode).HasColumnName("accounting_unit_code");
            
            builder.Property(x=>x.CityId).HasColumnName("city_id");
            
            builder.Property(x=>x.DistrictId).HasColumnName("district_id");
            
            builder.Property(x=>x.Name).HasColumnName("name");
            
        }
    }
}