using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Product : IEntity
    {
        public enum WarrantyTypes { Day, Month, Year };

        public Product(){}
        public Product(short deci, long barcode, int subsubcategoryId, int brandId, float commission, short warrantyPeriod, WarrantyTypes warrantyType, int id, float vatRate, short expiry, string name, string cargoCorporation, string description)
        {
            this.Deci = deci;
            this.Barcode = barcode;
            this.SubsubcategoryId = subsubcategoryId;
            this.BrandId = brandId;
            this.Commission = commission;
            this.WarrantyPeriod = warrantyPeriod;
            this.WarrantyType = warrantyType;
            this.Id = id;
            this.VatRate = vatRate;
            this.Expiry = expiry;
            this.Name = name;
            this.CargoCorporation = cargoCorporation;
            this.Description = description;

        }
        public short Deci { get; set; }
        public long Barcode { get; set; }
        public int SubsubcategoryId { get; set; }
        public int BrandId { get; set; }
        public float Commission { get; set; }
        public short WarrantyPeriod { get; set; }
        public WarrantyTypes WarrantyType { get; set; }
        public int Id { get; set; }
        public float VatRate { get; set; }
        public short Expiry { get; set; }
        public string Name { get; set; }
        public string[] Properties { get; set; }
        public string CargoCorporation { get; set; }
        public string Description { get; set; }

    }
}