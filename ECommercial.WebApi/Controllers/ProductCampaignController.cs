using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Entites.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/product-campaigns")]
    public class ProductCampaignController:CRUDBase<ProductCampaign>
    {
        
        private ProductCampaignManager _manager;
        public ProductCampaignController(ProductCampaignManager manager):base(manager)
        {
            _manager=manager;
        }

    }
}