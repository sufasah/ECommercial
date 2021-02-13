using ECommercial.Entities.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class FaqSubcategoryMap : IEntityTypeConfiguration<FaqCategory>
    {
         

        public void Configure(EntityTypeBuilder<FaqCategory> builder)
        {
            builder.ToTable(@"faq_subcategories",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<short?>();

            builder.Property(x=>x.Title).HasColumnName("title");
            
        }
    }
}