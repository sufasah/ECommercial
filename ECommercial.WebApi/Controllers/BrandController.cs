using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/brands")]
    public class BrandController:CRUDBase<Brand>
    {
        
        private IBrandService _manager;
        public BrandController(IBrandService manager):base(manager)
        {
            _manager=manager;
        }

    }
}