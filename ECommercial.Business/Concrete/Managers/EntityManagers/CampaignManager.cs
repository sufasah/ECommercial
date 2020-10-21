using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
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