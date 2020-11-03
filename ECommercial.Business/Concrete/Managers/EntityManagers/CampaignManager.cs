using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CampaignManager : EntityServiceBase<Campaign>,ICampaignService
    {
        private ICampaignDal _campaignDal;
        private IEntityDal<Campaign> _entityDal;
        private IMapper _mapper;
        public CampaignManager(ICampaignDal campaignDal,IEntityDal<Campaign> entityDal,IMapper mapper):base(campaignDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _campaignDal = campaignDal;
            _entityDal=entityDal;
            _mapper=mapper;
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