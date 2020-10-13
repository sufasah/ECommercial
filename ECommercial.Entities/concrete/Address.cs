
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public int UserShopId { get; set; }
        public long ReceiverNumber { get; set; }

        public int CityId { get; set; }

        public string address { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSurname { get; set; }
    }
}