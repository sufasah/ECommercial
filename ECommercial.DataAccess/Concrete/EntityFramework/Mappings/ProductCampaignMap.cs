using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class ProductCampaignMap : IEntityTypeConfiguration<ProductCampaign>
    {
        public void Configure(EntityTypeBuilder<ProductCampaign> builder)
        {
            builder.ToTable(@"product_campaigns",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();
            
            builder.Property(x=>x.CampaignId).HasColumnName("campaign_id");
            
            builder.Property(x=>x.ProductId).HasColumnName("product_id");
            
        }
    }
}