using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class BankMap:IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable(@"banks",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id");

            builder.Property(x=>x.Eft).HasColumnName("eft");
            
            builder.Property(x=>x.Fax).HasColumnName("fax");
            
            builder.Property(x=>x.Name).HasColumnName("name");
            
            builder.Property(x=>x.Swift).HasColumnName("swift");
            
            builder.Property(x=>x.Telephone).HasColumnName("telephone");
            
            builder.Property(x=>x.Telex).HasColumnName("telex");
            
            builder.Property(x=>x.Web).HasColumnName("web");
            
            builder.Property(x=>x.Address).HasColumnName("address");
            
        }
    }
}