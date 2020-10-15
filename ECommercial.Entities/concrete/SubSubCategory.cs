using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubSubCategory:IEntity
    {
        public short Id { get; set; }
        public short SubCategoryId { get; set; }
        public string Title { get; set; }
    }
}