using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
 
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(@"user_roles",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();
            
            builder.Property(x=>x.RoleId).HasColumnName("role_id");
            
            builder.Property(x=>x.UserId).HasColumnName("user_id");
            
        }
    }
}