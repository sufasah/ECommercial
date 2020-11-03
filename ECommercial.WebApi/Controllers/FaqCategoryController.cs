using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faq-categories")]
    public class FaqCategoryController:CRUDBase<FaqCategory>
    {
        
        private IFaqCategoryService _manager;
        public FaqCategoryController(IFaqCategoryService manager):base(manager)
        {
            _manager=manager;
        }

    }
}