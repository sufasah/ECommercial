using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/faq-sub-categories")]
    public class FaqSubCategoryController:CRUDBase<FaqSubCategory>
    {
        
        private FaqSubCategoryManager _manager;
        public FaqSubCategoryController(FaqSubCategoryManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}