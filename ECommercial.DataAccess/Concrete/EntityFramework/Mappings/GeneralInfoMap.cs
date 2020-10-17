using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class GeneralInfoMap : IEntityTypeConfiguration<GeneralInfo>
    {
         

        public void Configure(EntityTypeBuilder<GeneralInfo> builder)
        {
            builder.ToTable(@"general_infos",@"public");
            
            builder.HasKey(x=>x.Key);

            builder.Property(x=>x.Key).HasColumnName("key");

            builder.Property(x=>x.Value).HasColumnName("value");
            
        }
    }
}