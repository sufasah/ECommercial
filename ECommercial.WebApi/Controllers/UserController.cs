using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/users")]
    public class UserController:CRUDBase<User>
    {
        
        private IUserService _manager;
        public UserController(IUserService manager):base(manager)
        {
            _manager=manager;
        }

    }
}