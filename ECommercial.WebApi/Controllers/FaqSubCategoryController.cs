using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faq-sub-categories")]
    public class FaqSubCategoryController:CRUDBase<FaqSubCategory>
    {
        
        private IFaqSubCategoryService _manager;
        public FaqSubCategoryController(IFaqSubCategoryService manager):base(manager)
        {
            _manager=manager;
        }

    }
}