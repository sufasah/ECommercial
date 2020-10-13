using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class FaqCategory:IEntity
    {
        public Int16 Id { get; set; }
        public string Title { get; set; }
    }
}