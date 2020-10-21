using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Product : IEntity
    {
        public enum WarrantyTypes { Day, Month, Year };

        public Product(){}

        public Product(short deci, long barcode, short subsubcategoryId, int brandId, float commission, short warrantyPeriod, WarrantyTypes warrantyType, int ıd, float vatRate, short expiry, string name, string[] properties, string cargoCorporation, string description)
        {
            Deci = deci;
            Barcode = barcode;
            SubsubcategoryId = subsubcategoryId;
            BrandId = brandId;
            Commission = commission;
            WarrantyPeriod = warrantyPeriod;
            WarrantyType = warrantyType;
            Id = ıd;
            VatRate = vatRate;
            Expiry = expiry;
            Name = name;
            Properties = properties;
            CargoCorporation = cargoCorporation;
            Description = description;
        }

        public virtual short Deci { get; set; }
        public virtual long Barcode { get; set; }
        public virtual short SubsubcategoryId { get; set; }
        public virtual int BrandId { get; set; }
        public virtual float Commission { get; set; }
        public virtual short WarrantyPeriod { get; set; }
        public virtual WarrantyTypes WarrantyType { get; set; }
        public virtual int Id { get; set; }
        public virtual float VatRate { get; set; }
        public virtual short Expiry { get; set; }
        public virtual string Name { get; set; }
        public virtual string[] Properties { get; set;}
        public virtual string CargoCorporation { get; set; }
        public virtual string Description { get; set; }

    }
}