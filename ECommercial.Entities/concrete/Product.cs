using System.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ECommercial.Core.Entities;
using ECommercial.Entites.concrete;

namespace ECommercial.Entites.concrete
{
    public class Product : IEntity
    {
        public enum WarrantyTypes { Day, Month, Year };

        public Product(){}

        public Product(short deci, long barcode, int subsubcategoryId, int brandId, float commission, short warrantyPeriod, WarrantyTypes warrantyType, int ıd, float vatRate, short expiry, string name, string[] properties, string cargoCorporation, string description)
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
        public virtual int SubsubcategoryId { get; set; }
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
public class ProductEqualityComparer:IEqualityComparer<Product>{
    public bool Equals([AllowNull] Product x, [AllowNull] Product y)
        {
            if(x==null ||y==null)
                return false;
            return x.Barcode==y.Barcode && 
            x.BrandId==y.BrandId &&
            x.CargoCorporation.Equals(y.CargoCorporation) &&
            x.Commission==y.Commission &&
            x.Deci == y.Deci &&
            x.Description.Equals(y.Description) &&
            x.Expiry==y.Expiry &&
            x.Id==y.Id &&
            x.Name.Equals(y.Name) &&
            x.Properties.SequenceEqual(y.Properties) &&
            x.SubsubcategoryId == y.SubsubcategoryId &&
            x.VatRate == y.VatRate &&
            x.WarrantyPeriod == y.WarrantyPeriod &&
            x.WarrantyType == y.WarrantyType;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return (int)obj.Barcode ^obj.Id;
        }    
}