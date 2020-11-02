using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/orders")]
    public class OrderController:CRUDBase<Order>
    {
        
        private OrderManager _manager;
        public OrderController(OrderManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}