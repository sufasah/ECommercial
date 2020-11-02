using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/general-infos")]
    public class GeneralInfoController:CRUDBase<GeneralInfo>
    {
        
        private GeneralInfoManager _manager;
        public GeneralInfoController(GeneralInfoManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}