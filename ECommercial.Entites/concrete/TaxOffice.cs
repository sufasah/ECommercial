using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class TaxOffice:IEntity
    {
        public Int16 Id { get; set; }
        public Int16 CityId { get; set; }
        public Int16 DistrictId { get; set; }
        public int AccountingUnitCode { get; set; }
        public string Name { get; set; }
    }
}