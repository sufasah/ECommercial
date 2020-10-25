using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubSubCategory:IEntity
    {
        public SubSubCategory()
        {
        }

        public SubSubCategory(short? ıd, short? subCategoryId, string title)
        {
            Id = ıd;
            SubCategoryId = subCategoryId;
            Title = title;
        }

        public virtual short? Id { get; set; }
        public virtual short? SubCategoryId { get; set; }
        public virtual string Title { get; set; }
    }
}