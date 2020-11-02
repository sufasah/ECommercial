using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faq-categories")]
    public class FaqCategoryController:CRUDBase<FaqCategory>
    {
        
        private FaqCategoryManager _manager;
        public FaqCategoryController(FaqCategoryManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}