using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class FaqSubcategory:IEntity
    {
        public short Id { get; set; }
        public short FaqCategoryId { get; set; }
        public string Title { get; set; }
    }
}