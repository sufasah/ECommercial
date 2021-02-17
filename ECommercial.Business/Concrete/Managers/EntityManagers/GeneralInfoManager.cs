using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class GeneralInfoManager : EntityServiceBase<GeneralInfo>,IGeneralInfoService
    {
        private readonly IGeneralInfoDal _generalInfoDal;
        private readonly IEntityDal<GeneralInfo> _entityDal;
        private readonly IMapper _mapper;
        public GeneralInfoManager(IGeneralInfoDal generalInfoDal,IEntityDal<GeneralInfo> entityDal,IMapper mapper):base(generalInfoDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _generalInfoDal = generalInfoDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override GeneralInfo Add(GeneralInfo Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(GeneralInfo Entity)
        {
            base.Delete(Entity);
        }

        public override List<GeneralInfo> GetAll()
        {
            return base.GetAll();
        }

        public override GeneralInfo Update(GeneralInfo Entity)
        {
            return base.Update(Entity);
        }
    }
}