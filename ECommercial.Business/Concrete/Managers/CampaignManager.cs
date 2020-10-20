using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class CampaignManager : EntityServiceBase<Campaign>,ICampaignService
    {
        private ICampaignDal _CampaignDal;
        public CampaignManager(ICampaignDal CampaignDal,MemberInfo EntityPrimaryKeyMember):base(CampaignDal,EntityPrimaryKeyMember)
        {
            _CampaignDal = CampaignDal;
        }
    }
}