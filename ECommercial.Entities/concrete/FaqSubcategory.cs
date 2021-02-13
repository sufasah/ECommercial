using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class FaqSubCategory:IEntity
    {
        public FaqSubCategory()
        {
        }

        public FaqSubCategory(short? ıd, short? faqCategoryId, string title)
        {
            Id = ıd;
            FaqCategoryId = faqCategoryId;
            Title = title;
        }

        public virtual short? Id { get; set; }
        public virtual short? FaqCategoryId { get; set; }
        public virtual string Title { get; set; }
    }
}