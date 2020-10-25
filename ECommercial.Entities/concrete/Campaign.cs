using System;
using System.Security.Principal;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Campaign:IEntity
    {
        public Campaign(){}
        public Campaign(int? ıd, DateTime? startDateTime, DateTime? endDateTime, float? rate)
        {
            Id = ıd;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Rate = rate;
        }

        public virtual int? Id { get; set; }
        public virtual DateTime? StartDateTime { get; set; }
        public virtual DateTime? EndDateTime { get; set; }
        public virtual float? Rate { get; set; }
    }
}