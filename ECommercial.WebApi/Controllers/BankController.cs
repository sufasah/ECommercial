using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/banks")]
    public class BankController:CRUDBase<Bank>
    {
        
        private IBankService _manager;
        public BankController(IBankService manager):base(manager)
        {
            _manager=manager;
        }

    }
}