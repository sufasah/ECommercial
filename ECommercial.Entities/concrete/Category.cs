using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Category:IEntity
    {
        public short Id { get; set; }
        public string Title { get; set; }
    }
}