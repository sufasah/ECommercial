using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/shops")]
    public class ShopController:CRUDBase<Shop>
    {
        
        private IShopService _manager;
        public ShopController(IShopService manager):base(manager)
        {
            _manager=manager;
        }

    }
}