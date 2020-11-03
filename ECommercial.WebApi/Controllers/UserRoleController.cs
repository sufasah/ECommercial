using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-roles")]
    public class UserRoleController:CRUDBase<UserRole>
    {
        
        private IUserRoleService _manager;
        public UserRoleController(IUserRoleService manager):base(manager)
        {
            _manager=manager;
        }

    }
}