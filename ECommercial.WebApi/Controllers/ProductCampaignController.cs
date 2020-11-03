using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/product-campaigns")]
    public class ProductCampaignController:CRUDBase<ProductCampaign>
    {
        
        private IProductCampaignService _manager;
        public ProductCampaignController(IProductCampaignService manager):base(manager)
        {
            _manager=manager;
        }

    }
}