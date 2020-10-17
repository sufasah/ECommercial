using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubCategory:IEntity
    {
        public SubCategory()
        {
        }

        public SubCategory(short ıd, short categoryId, string title)
        {
            Id = ıd;
            CategoryId = categoryId;
            Title = title;
        }

        public virtual short Id { get; set; }
        public virtual short CategoryId { get; set; }
        public virtual string Title { get; set; }
    }
}