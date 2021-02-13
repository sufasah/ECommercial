using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class City:IEntity
    {
        public City()
        {
        }

        public City(short? ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public virtual short? Id { get; set; }
        public virtual string Name { get; set; }
    }
}