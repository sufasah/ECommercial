using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class FaqMap : IEntityTypeConfiguration<Faq>
    {
 

        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.ToTable(@"faqs",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");
            
            builder.Property(x=>x.Title).HasColumnName("title");
            
            builder.Property(x=>x.FaqSubcategoryId).HasColumnName("faq_subcategory_id");
            
            builder.Property(x=>x.Content).HasColumnName("content");
            
        }
    }
}