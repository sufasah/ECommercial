using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class FaqCategory:IEntity
    {
        public FaqCategory()
        {
        }

        public FaqCategory(short? ıd, string title)
        {
            Id = ıd;
            Title = title;
        }

        public virtual short? Id { get; set; }
        public virtual string Title { get; set; }
    }
}