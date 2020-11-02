using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
 
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable(@"logs",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();

            builder.Property(x=>x.Audit).HasColumnName("audit");
            
            builder.Property(x=>x.Date).HasColumnName("date");
            
            builder.Property(x=>x.Detail).HasColumnName("detail");
            
        }
    }
}