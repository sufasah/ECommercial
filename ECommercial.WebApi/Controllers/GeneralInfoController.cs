using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/general-infos")]
    public class GeneralInfoController:CRUDBase<GeneralInfo>
    {
        
        private IGeneralInfoService _manager;
        public GeneralInfoController(IGeneralInfoService manager):base(manager)
        {
            _manager=manager;
        }

    }
}