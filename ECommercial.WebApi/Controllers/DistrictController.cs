using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/districts")]
    public class DistrictController:CRUDBase<District>
    {
        
        private DistrictManager _manager;
        public DistrictController(DistrictManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}