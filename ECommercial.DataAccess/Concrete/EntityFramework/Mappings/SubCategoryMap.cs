using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class SubCategoryMap : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable(@"subcategories",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<short>();

            builder.Property(x=>x.Title).HasColumnName("title");

        }
    }
}