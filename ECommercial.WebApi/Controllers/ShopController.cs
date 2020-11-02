using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/shops")]
    public class ShopController:CRUDBase<Shop>
    {
        
        private ShopManager _manager;
        public ShopController(ShopManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}