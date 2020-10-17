using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Faq:IEntity
    {
        public Faq()
        {
        }

        public Faq(short ıd, short faqSubcategoryId, string title, string content)
        {
            Id = ıd;
            FaqSubcategoryId = faqSubcategoryId;
            Title = title;
            Content = content;
        }

        public virtual short Id { get; set; }
        public virtual short FaqSubcategoryId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
    }
}