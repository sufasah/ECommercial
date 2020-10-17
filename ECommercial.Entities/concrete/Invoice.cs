using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Invoice:IEntity
    {
        public Invoice()
        {
        }

        public Invoice(Types type, int userId, long ınvoiceeNumber, short cityId, int ıd, string name, string ınvoiceeName, string ınvoiceeSurname, string address)
        {
            Type = type;
            UserId = userId;
            InvoiceeNumber = ınvoiceeNumber;
            CityId = cityId;
            Id = ıd;
            Name = name;
            InvoiceeName = ınvoiceeName;
            InvoiceeSurname = ınvoiceeSurname;
            Address = address;
        }

        public enum Types{individual,institutional};
        public virtual Types? Type { get; set; }
        public virtual int? UserId { get; set; }
        public virtual long InvoiceeNumber { get; set; }
        public virtual short CityId { get; set; }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string InvoiceeName { get; set; }
        public virtual string InvoiceeSurname { get; set; }
        public virtual string Address { get; set; }
    }
}