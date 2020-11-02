using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/users")]
    public class UserController:CRUDBase<User>
    {
        
        private UserManager _manager;
        public UserController(UserManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}