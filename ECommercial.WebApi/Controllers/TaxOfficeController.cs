using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/tax-offices")]
    public class TaxOfficeController:CRUDBase<TaxOffice>
    {
        
        private ITaxOfficeService _manager;
        public TaxOfficeController(ITaxOfficeService manager):base(manager)
        {
            _manager=manager;
        }

    }
}