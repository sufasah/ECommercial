using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/slides")]
    public class SlideController:CRUDBase<Slide>
    {
        
        private SlideManager _manager;
        public SlideController(SlideManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}