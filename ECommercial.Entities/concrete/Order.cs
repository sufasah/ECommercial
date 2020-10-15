using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Order:IEntity
    {
        public virtual short Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int ClaimAddressId { get; set; }
        public virtual int InvoiceId { get; set; }
        public virtual DateTime Datetime { get; set; }
    }
}