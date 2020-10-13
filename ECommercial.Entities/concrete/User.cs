using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class User:IEntity
    {
        public bool SmsNotificationEnabled { get; set; }
        public bool Gender { get; set; }
        public bool EmailNotificationEnabled { get; set; }
        public int Id { get; set; }
        public long Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}