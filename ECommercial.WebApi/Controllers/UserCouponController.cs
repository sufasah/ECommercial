using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-coupons")]
    public class UserCouponController:CRUDBase<UserCoupon>
    {
        
        private UserCouponManager _manager;
        public UserCouponController(UserCouponManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}