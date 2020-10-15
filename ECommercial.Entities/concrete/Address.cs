
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Address:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int UserShopId { get; set; }
        public virtual long ReceiverNumber { get; set; }

        public virtual int CityId { get; set; }

        public virtual string address { get; set; }
        public virtual string ReceiverName { get; set; }
        public virtual string ReceiverSurname { get; set; }
    }
}