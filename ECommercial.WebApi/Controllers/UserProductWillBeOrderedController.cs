using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-products-will-be-ordered")]
    public class UserProductWillBeOrderedController:CRUDBase<UserProductWillBeOrdered>
    {
        
        private IUserProductWillBeOrderedService _manager;
        public UserProductWillBeOrderedController(IUserProductWillBeOrderedService manager):base(manager)
        {
            _manager=manager;
        }

    }
}