using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"categories");

            Id(x=>x.Id).Column("id");

            Map(x=>x.Title).Column("title");
            
        }
    }
}