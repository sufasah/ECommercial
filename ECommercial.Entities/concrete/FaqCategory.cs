using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class FaqCategory:IEntity
    {
        public virtual short Id { get; set; }
        public virtual string Title { get; set; }
    }
}