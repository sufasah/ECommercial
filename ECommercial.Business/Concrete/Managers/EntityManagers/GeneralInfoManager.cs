using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class GeneralInfoManager : EntityServiceBase<GeneralInfo>,IGeneralInfoService
    {
        private IGeneralInfoDal _generalInfoDal;
        private IEntityDal<GeneralInfo> _entityDal;
        public GeneralInfoManager(IGeneralInfoDal generalInfoDal,IEntityDal<GeneralInfo> entityDal):base(generalInfoDal,entityDal.GetPrimaryKeyMember())
        {
            _generalInfoDal = generalInfoDal;
            _entityDal=entityDal;
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