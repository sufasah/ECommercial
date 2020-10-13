using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class FaqCategoryMap : ClassMap<FaqCategory>
    {
        public FaqCategoryMap()
        {
            Table(@"faq_categories");
            Id(x=>x.Id).Column("id");

            Map(x=>x.Title).Column("title");
                        
        }
    }
}