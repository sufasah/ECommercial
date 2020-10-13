using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubCategory:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 CategoryId { get; set; }
        public string Title { get; set; }
    }
}