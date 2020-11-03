using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/user-coupons")]
    public class UserCouponController:CRUDBase<UserCoupon>
    {
        
        private IUserCouponService _manager;
        public UserCouponController(IUserCouponService manager):base(manager)
        {
            _manager=manager;
        }

    }
}