using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class UserProductWillBeOrderedMap : IEntityTypeConfiguration<UserProductWillBeOrdered>
    {
 
        public void Configure(EntityTypeBuilder<UserProductWillBeOrdered> builder)
        {
            builder.ToTable(@"user_products_will_be_ordered",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
        }
    }
}