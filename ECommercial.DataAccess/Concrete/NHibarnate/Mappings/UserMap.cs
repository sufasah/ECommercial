using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table(@"users");
            Id(x=>x.Id).Column("id");

            Map(x=>x.BirthDate).Column("birthdate");

            Map(x=>x.Email).Column("email");
            
            Map(x=>x.EmailNotificationEnabled).Column("email_notification_enabled");
            
            Map(x=>x.Gender).Column("gender");
            
            Map(x=>x.Name).Column("name");
            
            Map(x=>x.Phone).Column("phone");
            
            Map(x=>x.SmsNotificationEnabled).Column("sms_notification_enabled");
            
            Map(x=>x.Surname).Column("surname");
            
        }
    }
}