using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductRate:IEntity
    {
        public virtual DateTime Datetime { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int UserId { get; set; }
        public virtual bool HidUserInfoEnabled { get; set; }
        public virtual int Id { get; set; }
        public virtual short Rate { get; set; }
        public virtual string Comment { get; set; }
        public virtual string[] Images { get; set; }
    }
}