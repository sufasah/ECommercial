using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-products-will-be-ordered")]
    public class UserProductWillBeOrderedController:CRUDBase<UserProductWillBeOrdered>
    {
        
        private UserProductWillBeOrderedManager _manager;
        public UserProductWillBeOrderedController(UserProductWillBeOrderedManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}