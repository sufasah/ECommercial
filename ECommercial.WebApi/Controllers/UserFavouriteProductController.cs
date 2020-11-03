using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-favourite-products")]
    public class UserFavouriteProductController:CRUDBase<UserFavouriteProduct>
    {
        
        private IUserFavouriteProductService _manager;
        public UserFavouriteProductController(IUserFavouriteProductService manager):base(manager)
        {
            _manager=manager;
        }

    }
}