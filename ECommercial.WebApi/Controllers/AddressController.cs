using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/addresses")]
    public class AddressController:CRUDBase<Address>
    {
        
        private AddressManager _manager;
        public AddressController(AddressManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}