using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Order:IEntity
    {
        public Order()
        {
        }

        public Order(long ıd, int userId, int claimAddressId, int ınvoiceId, DateTime datetime)
        {
            Id = ıd;
            UserId = userId;
            ClaimAddressId = claimAddressId;
            InvoiceId = ınvoiceId;
            Datetime = datetime;
        }

        public virtual long Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int ClaimAddressId { get; set; }
        public virtual int InvoiceId { get; set; }
        public virtual DateTime Datetime { get; set; }
    }
}