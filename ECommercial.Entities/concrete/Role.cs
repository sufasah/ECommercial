using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Role:IEntity
    {
        public Role()
        {
            
        }

        public Role(int? ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public virtual int? Id { get; set; }

        public virtual string Name { get; set; }
        
    }
}