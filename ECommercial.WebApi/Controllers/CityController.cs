using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/cities")]
    public class CityController:CRUDBase<City>
    {
        
        private ICityService _manager;
        public CityController(ICityService manager):base(manager)
        {
            _manager=manager;
        }

    }
}