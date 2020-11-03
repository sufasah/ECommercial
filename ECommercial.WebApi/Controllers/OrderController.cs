using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/orders")]
    public class OrderController:CRUDBase<Order>
    {
        
        private IOrderService _manager;
        public OrderController(IOrderService manager):base(manager)
        {
            _manager=manager;
        }

    }
}