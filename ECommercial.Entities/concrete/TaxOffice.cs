using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class TaxOffice:IEntity
    {
        public short Id { get; set; }
        public short CityId { get; set; }
        public short DistrictId { get; set; }
        public int AccountingUnitCode { get; set; }
        public string Name { get; set; }
    }
}