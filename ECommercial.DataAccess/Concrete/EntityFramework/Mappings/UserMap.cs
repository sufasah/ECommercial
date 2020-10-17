using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
 
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(@"users",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();

            builder.Property(x=>x.BirthDate).HasColumnName("birtdate");
            
            builder.Property(x=>x.Email).HasColumnName("email");
            
            builder.Property(x=>x.EmailNotificationEnabled).HasColumnName("email_notification_enabled");
            
            builder.Property(x=>x.Gender).HasColumnName("gender");
            
            builder.Property(x=>x.Phone).HasColumnName("phone");
            
            builder.Property(x=>x.SmsNotificationEnabled).HasColumnName("sms_notification_enabled");
            
            builder.Property(x=>x.Surname).HasColumnName("surname");
            
        }
    }
}