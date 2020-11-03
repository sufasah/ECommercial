using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/shop-products")]
    public class ShopProductController:CRUDBase<ShopProduct>
    {
        
        private IShopProductService _manager;
        public ShopProductController(IShopProductService manager):base(manager)
        {
            _manager=manager;
        }

    }
}