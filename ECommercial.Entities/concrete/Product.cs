using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Product:IEntity
    {
        public enum WarrantyTypes{Day,Month,Year};
        public Int16 Deci { get; set; }
        public long Barcode { get; set; }
        public int SubsubcategoryId { get; set; }
        public int BrandId { get; set; }
        public float Commission { get; set; }
        public Int16 WarrantyPeriod { get; set; }
        public WarrantyTypes WarrantyType { get; set; }
        public int Id { get; set; }
        public float VatRate { get; set; }
        public Int16 Expiry { get; set; }
        public string Name { get; set; }
        public string[] Properties { get; set; }
        public string CargoCorporation { get; set; }
        public string Description { get; set; }

    }
}