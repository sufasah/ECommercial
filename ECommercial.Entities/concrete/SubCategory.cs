using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class SubCategory:IEntity
    {
        public short Id { get; set; }
        public short CategoryId { get; set; }
        public string Title { get; set; }
    }
}