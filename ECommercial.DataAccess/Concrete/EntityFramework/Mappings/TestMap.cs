using ECommercial.Entities.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class TestMap : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable(@"tests");

            builder.HasKey(o=>o.Id);

            builder.Property(o=>o.Id).HasColumnName("id");

            builder.Property(o=>o.Chr).HasColumnName("chr");

            builder.Property(o=>o.Varchr).HasColumnName("varchr");

            builder.Property(o=>o.VarchrArray).HasColumnName("varchr_array");

            builder.Property(o=>o.Intgr).HasColumnName("intgr");
        }
    }
}