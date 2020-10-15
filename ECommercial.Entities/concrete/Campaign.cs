using System;
using System.Security.Principal;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Campaign:IEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime StartDateTime { get; set; }
        public virtual DateTime EndDateTime { get; set; }
        public virtual float Rate { get; set; }
    }
}