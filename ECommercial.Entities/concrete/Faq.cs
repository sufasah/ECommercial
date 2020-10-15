using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Faq:IEntity
    {
        public short Id { get; set; }
        public short FaqSubcategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}