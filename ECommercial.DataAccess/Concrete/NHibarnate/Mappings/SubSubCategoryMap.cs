using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class SubSubCategoryMap : ClassMap<SubSubCategory>
    {
        public SubSubCategoryMap()
        {
            Table(@"subsubcategories");
            Id(x=>x.Id).Column("id");

            Map(x=>x.SubCategoryId).Column("subcategory_id");
            
            Map(x=>x.Title).Column("title");
            
        }
    }
}