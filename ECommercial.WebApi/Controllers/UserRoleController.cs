using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-roles")]
    public class UserRoleController:CRUDBase<UserRole>
    {
        
        private UserRoleManager _manager;
        public UserRoleController(UserRoleManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}