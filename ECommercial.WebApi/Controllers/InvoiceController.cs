using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/invoices")]
    public class InvoiceController:CRUDBase<Invoice>
    {
        
        private IInvoiceService _manager;
        public InvoiceController(IInvoiceService manager):base(manager)
        {
            _manager=manager;
        }

    }
}