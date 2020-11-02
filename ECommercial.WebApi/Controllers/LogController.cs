using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/uogs")]
    public class LogController:CRUDBase<Log>
    {
        
        private LogManager _manager;
        public LogController(LogManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}