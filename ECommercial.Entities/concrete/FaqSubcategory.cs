using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class FaqSubcategory:IEntity
    {
        public virtual short Id { get; set; }
        public virtual short FaqCategoryId { get; set; }
        public virtual string Title { get; set; }
    }
}