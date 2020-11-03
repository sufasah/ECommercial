using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/districts")]
    public class DistrictController:CRUDBase<District>
    {
        
        private IDistrictService _manager;
        public DistrictController(IDistrictService manager):base(manager)
        {
            _manager=manager;
        }

    }
}