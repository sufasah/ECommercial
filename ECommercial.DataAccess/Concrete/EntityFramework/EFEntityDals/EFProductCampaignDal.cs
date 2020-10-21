
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;
using ECommercial.DataAccess.EntityFramework;
namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFProductCampaignDal : EFIEntityRepositoryBase<ProductCampaign,ECommercialContext>,IProductCampaignDal
    {
        
    }
}