using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Faq:IEntity
    {
        public virtual short Id { get; set; }
        public virtual short FaqSubcategoryId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
    }
}