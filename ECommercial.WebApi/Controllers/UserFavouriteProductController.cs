using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-favourite-products")]
    public class UserFavouriteProductController:CRUDBase<UserFavouriteProduct>
    {
        
        private UserFavouriteProductManager _manager;
        public UserFavouriteProductController(UserFavouriteProductManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}