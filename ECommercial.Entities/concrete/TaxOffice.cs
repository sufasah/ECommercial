using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class TaxOffice:IEntity
    {
        public TaxOffice()
        {
        }

        public TaxOffice(short? ıd, short? cityId, short? districtId, int? accountingUnitCode, string name)
        {
            Id = ıd;
            CityId = cityId;
            DistrictId = districtId;
            AccountingUnitCode = accountingUnitCode;
            Name = name;
        }

        public virtual short? Id { get; set; }
        public virtual short? CityId { get; set; }
        public virtual short? DistrictId { get; set; }
        public virtual int? AccountingUnitCode { get; set; }
        public virtual string Name { get; set; }
    }
}