using System.Data;
using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;

namespace ECommercial.Core.DataAccess.NHibernate.Mappings
{
    public class AddressMap:ClassMap<Address>
    {
         public AddressMap(){
             Table(@"addresses");

             LazyLoad();

             Id(x=>x.Id).Column("id");

             Map(x=>x.address).Column("address");

             Map(x=>x.CityId).Column("city_id");

             Map(x=>x.ReceiverName).Column("receiver_name");

             Map(x=>x.ReceiverNumber).Column("receiver_number");
             
             Map(x=>x.ReceiverSurname).Column("receiver_surname");
             
             Map(x=>x.UserShopId).Column("user_shop_id");


         }
    }
}