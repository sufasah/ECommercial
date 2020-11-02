using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/invoices")]
    public class InvoiceController:CRUDBase<Invoice>
    {
        
        private InvoiceManager _manager;
        public InvoiceController(InvoiceManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}