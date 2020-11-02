using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/campaigns")]
    public class CampaignController:CRUDBase<Campaign>
    {
        
        private CampaignManager _manager;
        public CampaignController(CampaignManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}