using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/cities")]
    public class CityController:CRUDBase<City>
    {
        
        private CityManager _manager;
        public CityController(CityManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}