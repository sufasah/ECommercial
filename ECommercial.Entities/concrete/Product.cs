using System;
using System.Collections.Generic;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Product : IEntity
    {
        public enum WarrantyTypes { Day, Month, Year };

        public Product(){}
        public Product(short deci, long barcode, int subsubcategoryId, int brandId, float commission, short warrantyPeriod, WarrantyTypes warrantyType, int id, float vatRate, short expiry, string name, string cargoCorporation, string description,string properties)
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
            this.Properties = properties;
        }
        public virtual short Deci { get; set; }
        public virtual long Barcode { get; set; }
        public virtual int SubsubcategoryId { get; set; }
        public virtual int BrandId { get; set; }
        public virtual float Commission { get; set; }
        public virtual short WarrantyPeriod { get; set; }
        public virtual WarrantyTypes WarrantyType { get; set; }
        public virtual int Id { get; set; }
        public virtual float VatRate { get; set; }
        public virtual short Expiry { get; set; }
        public virtual string Name { get; set; }
        private string _properties;
        public virtual string Properties { 
            get{return _properties;} 
            set{
                var x = value;
                this._properties=x;
            } 
        }
        public virtual string CargoCorporation { get; set; }
        public virtual string Description { get; set; }

    }
}