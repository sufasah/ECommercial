using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/products")]
    public class ProductController:CRUDBase<Product>
    {
        
        private ProductManager _manager;
        public ProductController(ProductManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}