using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/product-rates")]
    public class ProductRateController:CRUDBase<ProductRate>
    {
        
        private IProductRateService _manager;
        public ProductRateController(IProductRateService manager):base(manager)
        {
            _manager=manager;
        }

    }
}