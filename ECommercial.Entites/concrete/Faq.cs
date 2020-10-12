using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Faq:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 FaqSubcategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}