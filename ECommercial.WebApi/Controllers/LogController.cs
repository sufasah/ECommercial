using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/logs")]
    public class LogController:CRUDBase<Log>
    {
        
        private ILogService _manager;
        public LogController(ILogService manager):base(manager)
        {
            _manager=manager;
        }

    }
}