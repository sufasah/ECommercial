using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/tax-offices")]
    public class TaxOfficeController:CRUDBase<TaxOffice>
    {
        
        private TaxOfficeManager _manager;
        public TaxOfficeController(TaxOfficeManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}