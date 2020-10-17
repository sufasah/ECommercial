using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(@"cities",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<short>();

            builder.Property(x=>x.Name).HasColumnName("name");
            
        }
    }
}