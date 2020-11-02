using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faqs")]
    public class FaqController:CRUDBase<Faq>
    {
        
        private FaqManager _manager;
        public FaqController(FaqManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}