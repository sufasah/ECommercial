using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/sub-sub-categories")]
    public class SubSubCategoryController:CRUDBase<SubSubCategory>
    {
        
        private ISubSubCategoryService _manager;
        public SubSubCategoryController(ISubSubCategoryService manager):base(manager)
        {
            _manager=manager;
        }

    }
}