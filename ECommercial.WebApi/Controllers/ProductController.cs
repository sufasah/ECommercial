using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers
{
    public class ProductController:CRUDBase<Product>
    {
        private ProductManager _manager;
        public ProductController(ProductManager manager):base(manager)
        {
            _manager=manager;
        }
        [Route("test")]
        public IActionResult test(){
            return Ok(nameof(Product));
        }
        
    }
}