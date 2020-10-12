using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Order:IEntity
    {
        public Int16 Id { get; set; }
        public int UserId { get; set; }
        public int ClaimAddressId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Datetime { get; set; }
    }
}