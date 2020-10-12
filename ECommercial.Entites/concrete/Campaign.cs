using System;
using System.Security.Principal;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float Rate { get; set; }
    }
}