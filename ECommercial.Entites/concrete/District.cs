using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class District:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 CityId { get; set; }
        public string Name { get; set; }
    }
}