using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/sub-sub-categories")]
    public class SubSubCategoryController:CRUDBase<SubSubCategory>
    {
        
        private SubSubCategoryManager _manager;
        public SubSubCategoryController(SubSubCategoryManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}