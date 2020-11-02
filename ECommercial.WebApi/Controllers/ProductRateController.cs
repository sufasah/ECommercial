using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/product-rates")]
    public class ProductRateController:CRUDBase<ProductRate>
    {
        
        private ProductRateManager _manager;
        public ProductRateController(ProductRateManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}