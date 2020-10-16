using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class FaqSubcategoryMap : ClassMap<FaqCategory>
    {
        public FaqSubcategoryMap()
        {
            Table(@"faq_subcategories");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Title).Column("title");
            
        }
    }
}