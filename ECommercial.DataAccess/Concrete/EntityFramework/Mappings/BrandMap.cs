using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable(@"brands",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();

            builder.Property(x=>x.brand).HasColumnName("brand");
            
        }
    }
}