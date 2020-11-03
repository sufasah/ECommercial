using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/addresses")]
    public class AddressController:CRUDBase<Address>
    {
        
        private IAddressService _manager;
        public AddressController(IAddressService manager):base(manager)
        {
            _manager=manager;
        }

    }
}