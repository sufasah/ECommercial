using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/brands")]
    public class BrandController:CRUDBase<Brand>
    {
        
        private BrandManager _manager;
        public BrandController(BrandManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}