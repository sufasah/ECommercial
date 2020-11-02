using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/roles")]
    public class RoleController:CRUDBase<Role>
    {
        
        private RoleManager _manager;
        public RoleController(RoleManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}