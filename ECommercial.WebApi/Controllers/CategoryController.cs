using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/categories")]
    public class CategoryController:CRUDBase<Category>
    {
        
        private ICategoryService _manager;
        public CategoryController(ICategoryService manager):base(manager)
        {
            _manager=manager;
        }

    }
}