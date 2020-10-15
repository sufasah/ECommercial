using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class User:IEntity
    {
        public virtual bool SmsNotificationEnabled { get; set; }
        public virtual bool Gender { get; set; }
        public virtual bool EmailNotificationEnabled { get; set; }
        public virtual int Id { get; set; }
        public virtual long Phone { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string Email { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
    }
}