using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class CampaignMap : IEntityTypeConfiguration<Campaign>
    {

        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable(@"campaigns",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();
            
            builder.Property(x=>x.Rate).HasColumnName("rate");
            
            builder.Property(x=>x.StartDateTime).HasColumnName("start_datetime");
            
            builder.Property(x=>x.EndDateTime).HasColumnName("end_datetime");
            
        }
    }
}