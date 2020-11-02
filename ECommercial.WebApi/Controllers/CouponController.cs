using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/coupons")]
    public class CouponController:CRUDBase<Coupon>
    {
        
        private CouponManager _manager;
        public CouponController(CouponManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}