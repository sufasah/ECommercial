using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/sub-categories")]
    public class SubCategoryController:CRUDBase<SubCategory>
    {
        
        private SubCategoryManager _manager;
        public SubCategoryController(SubCategoryManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}