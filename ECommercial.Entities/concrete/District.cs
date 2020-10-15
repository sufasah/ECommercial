using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class District:IEntity
    {
        public short Id { get; set; }
        public short CityId { get; set; }
        public string Name { get; set; }
    }
}