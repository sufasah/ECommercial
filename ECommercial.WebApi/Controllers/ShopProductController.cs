using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/shop-products")]
    public class ShopProductController:CRUDBase<ShopProduct>
    {
        
        private ShopProductManager _manager;
        public ShopProductController(ShopProductManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}