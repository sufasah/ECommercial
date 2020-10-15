using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public enum typeEnum{individual,institutional};
    public class Invoice:IEntity
    {
        public typeEnum Type { get; set; }
        public int UserId { get; set; }
        public long InvoiceeNumber { get; set; }
        public short CityId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string InvoiceeName { get; set; }
        public string InvoiceeSurname { get; set; }
        public string Address { get; set; }
    }
}