using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/banks")]
    public class BankController:CRUDBase<Bank>
    {
        
        private BankManager _manager;
        public BankController(BankManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}