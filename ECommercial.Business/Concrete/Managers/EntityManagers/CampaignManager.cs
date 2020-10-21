using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CampaignManager : EntityServiceBase<Campaign>,ICampaignService
    {
        private ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal CampaignDal,MemberInfo EntityPrimaryKeyMember):base(CampaignDal,EntityPrimaryKeyMember)
        {
            _campaignDal = CampaignDal;
        }
        public override Campaign Add(Campaign Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Campaign Entity)
        {
            base.Delete(Entity);
        }

        public override List<Campaign> GetAll()
        {
            return base.GetAll();
        }

        public override Campaign Update(Campaign Entity)
        {
            return base.Update(Entity);
        }
    }
}