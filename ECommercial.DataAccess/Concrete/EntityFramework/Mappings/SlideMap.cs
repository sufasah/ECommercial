using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class SlideMap : IEntityTypeConfiguration<Slide>
    {

        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable(@"slides",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();

            builder.Property(x=>x.ImageUrl).HasColumnName("image_url");
            
            builder.Property(x=>x.RouteUrl).HasColumnName("route_url");
            
            builder.Property(x=>x.SlideOrder).HasColumnName("slide_order");
        }
    }
}