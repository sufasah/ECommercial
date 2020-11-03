using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/slides")]
    public class SlideController:CRUDBase<Slide>
    {
        
        private ISlideService _manager;
        public SlideController(ISlideService manager):base(manager)
        {
            _manager=manager;
        }

    }
}