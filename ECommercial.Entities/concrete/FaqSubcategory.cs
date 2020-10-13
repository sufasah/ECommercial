using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class FaqSubcategory:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 FaqCategoryId { get; set; }
        public string Title { get; set; }
    }
}