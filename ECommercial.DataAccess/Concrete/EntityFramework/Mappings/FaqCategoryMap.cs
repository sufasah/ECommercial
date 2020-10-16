using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class FaqCategoryMap : IEntityTypeConfiguration<FaqCategory>
    {

        public void Configure(EntityTypeBuilder<FaqCategory> builder)
        {
            builder.ToTable(@"faq_categories",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.Title).HasColumnName("title");
            
        }
    }
}