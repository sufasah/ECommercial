using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class SlideMap : ClassMap<Slide>
    {
        public SlideMap()
        {
            Table(@"slides");
            Id(x=>x.Id).Column("id");

            Map(x=>x.ImageUrl).Column("image_url");
            
            Map(x=>x.RouteUrl).Column("route_url");
            
            Map(x=>x.SlideOrder).Column("slide_order");
            
        }
    }
}