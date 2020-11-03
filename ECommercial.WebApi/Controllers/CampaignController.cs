using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/campaigns")]
    public class CampaignController:CRUDBase<Campaign>
    {
        
        private ICampaignService _manager;
        public CampaignController(ICampaignService manager):base(manager)
        {
            _manager=manager;
        }

    }
}