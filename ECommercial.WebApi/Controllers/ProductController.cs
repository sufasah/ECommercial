using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/products")]
    public class ProductController:CRUDBase<Product>
    {
        
        private IProductService _manager;
        public ProductController(IProductService manager):base(manager)
        {
            _manager=manager;
        }

    }
}