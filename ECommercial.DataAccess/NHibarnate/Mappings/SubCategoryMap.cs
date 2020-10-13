using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class SubCategoryMap : ClassMap<SubCategory>
    {
        public SubCategoryMap()
        {
            Table(@"subcategories");
            Id(x=>x.Id).Column("id");
            
            Map(x=>x.CategoryId).Column("category_id");
            
            Map(x=>x.Title).Column("title");
            
        }
    }
}