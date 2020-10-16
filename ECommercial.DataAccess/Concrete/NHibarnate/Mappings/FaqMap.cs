using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class FaqMap : ClassMap<Faq>
    {
        public FaqMap()
        {
            Table(@"faqs");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Title).Column("title");
            
            Map(x=>x.FaqSubcategoryId).Column("faq_subcategory_id");
            
            Map(x=>x.Content).Column("content");
            
        }
    }
}