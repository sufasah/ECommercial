using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class Address:IEntity
    {
        public Address(){}
        public Address(int? ıd, int? userShopId, long? receiverNumber, short? cityId, string address, string receiverName, string receiverSurname)
        {
            Id = ıd;
            UserShopId = userShopId;
            ReceiverNumber = receiverNumber;
            CityId = cityId;
            this.address = address;
            ReceiverName = receiverName;
            ReceiverSurname = receiverSurname;
        }

        public virtual int? Id { get; set; }
        public virtual int? UserShopId { get; set; }
        public virtual long? ReceiverNumber { get; set; }

        public virtual short? CityId { get; set; }

        public virtual string address { get; set; }
        public virtual string ReceiverName { get; set; }
        public virtual string ReceiverSurname { get; set; }
    }
}