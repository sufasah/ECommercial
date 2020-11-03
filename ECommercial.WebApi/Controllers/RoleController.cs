using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/roles")]
    public class RoleController:CRUDBase<Role>
    {
        
        private IRoleService _manager;
        public RoleController(IRoleService manager):base(manager)
        {
            _manager=manager;
        }

    }
}