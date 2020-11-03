using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/order-products")]
    public class OrderProductController:CRUDBase<OrderProduct>
    {
        
        private IOrderProductService _manager;
        public OrderProductController(IOrderProductService manager):base(manager)
        {
            _manager=manager;
        }

    }
}