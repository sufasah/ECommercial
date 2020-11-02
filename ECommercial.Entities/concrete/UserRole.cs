using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class UserRole:IEntity
    {
        public UserRole()
        {
            
        }

        public UserRole(int? ıd, int? userId, int? roleId)
        {
            Id = ıd;
            UserId = userId;
            RoleId = roleId;
        }

        public virtual int? Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual int? RoleId { get; set; }
    }
}