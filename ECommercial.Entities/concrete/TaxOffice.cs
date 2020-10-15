using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class TaxOffice:IEntity
    {
        public virtual short Id { get; set; }
        public virtual short CityId { get; set; }
        public virtual short DistrictId { get; set; }
        public virtual int AccountingUnitCode { get; set; }
        public virtual string Name { get; set; }
    }
}