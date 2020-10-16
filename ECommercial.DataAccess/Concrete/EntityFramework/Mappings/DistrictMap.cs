using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class DistrictMap : IEntityTypeConfiguration<District>
    { 

        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(@"districts",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.Name).HasColumnName("name");
            
            builder.Property(x=>x.CityId).HasColumnName("city_id");
            
        }
    }
}