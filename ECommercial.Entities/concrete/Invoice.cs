using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public enum typeEnum{individual,institutional};
    public class Invoice:IEntity
    {
        public virtual typeEnum Type { get; set; }
        public virtual int UserId { get; set; }
        public virtual long InvoiceeNumber { get; set; }
        public virtual short CityId { get; set; }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string InvoiceeName { get; set; }
        public virtual string InvoiceeSurname { get; set; }
        public virtual string Address { get; set; }
    }
}