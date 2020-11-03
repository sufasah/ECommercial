using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faqs")]
    public class FaqController:CRUDBase<Faq>
    {
        
        private IFaqService _manager;
        public FaqController(IFaqService manager):base(manager)
        {
            _manager=manager;
        }

    }
}