using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/coupons")]
    public class CouponController:CRUDBase<Coupon>
    {
        
        private ICouponService _manager;
        public CouponController(ICouponService manager):base(manager)
        {
            _manager=manager;
        }

    }
}