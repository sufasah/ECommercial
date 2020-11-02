using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/order-products")]
    public class OrderProductController:CRUDBase<OrderProduct>
    {
        
        private OrderProductManager _manager;
        public OrderProductController(OrderProductManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}