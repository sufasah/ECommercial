using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/categories")]
    public class CategoryController:CRUDBase<Category>
    {
        
        private CategoryManager _manager;
        public CategoryController(CategoryManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}