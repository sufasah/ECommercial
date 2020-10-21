using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductCampaignManager : EntityServiceBase<ProductCampaign>,IProductCampaignService
    {
        private IProductCampaignDal _ProductCampaignDal;
        public ProductCampaignManager(IProductCampaignDal ProductCampaignDal,MemberInfo EntityPrimaryKeyMember):base(ProductCampaignDal,EntityPrimaryKeyMember)
        {
            _ProductCampaignDal = ProductCampaignDal;
        }
    }
}