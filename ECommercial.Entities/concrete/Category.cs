using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class Category:IEntity
    {
        
        public Category()
        {
        }

        public Category(short? ıd, string title)
        {
            Id = ıd;
            Title = title;
        }

        public virtual short? Id { get; set; }
        public virtual string Title { get; set; }
    }
}