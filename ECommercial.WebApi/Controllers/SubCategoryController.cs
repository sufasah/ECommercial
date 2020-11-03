using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/sub-categories")]
    public class SubCategoryController:CRUDBase<SubCategory>
    {
        
        private ISubCategoryService _manager;
        public SubCategoryController(ISubCategoryService manager):base(manager)
        {
            _manager=manager;
        }

    }
}