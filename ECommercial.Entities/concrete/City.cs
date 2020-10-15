using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class City:IEntity
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }
}