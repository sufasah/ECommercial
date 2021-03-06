using ECommercial.Entities.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class SubSubCategoryMap : IEntityTypeConfiguration<SubSubCategory>
    {
        public void Configure(EntityTypeBuilder<SubSubCategory> builder)
        {
            builder.ToTable(@"subsubcategories",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<short?>();

            builder.Property(x=>x.SubCategoryId).HasColumnName("subcategory_id");
            
            builder.Property(x=>x.Title).HasColumnName("title");
            
        }
    }
}