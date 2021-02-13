using ECommercial.Entities.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
 
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(@"roles",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.Name).HasColumnName("name");            
        }
    }
}