using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubSubCategory:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 SubCategoryId { get; set; }
        public string Title { get; set; }
    }
}