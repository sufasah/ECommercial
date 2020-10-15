using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Category:IEntity
    {
        public virtual short Id { get; set; }
        public virtual string Title { get; set; }
    }
}