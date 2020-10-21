using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class GeneralInfoManager : EntityServiceBase<GeneralInfo>,IGeneralInfoService
    {
        private IGeneralInfoDal _GeneralInfoDal;
        public GeneralInfoManager(IGeneralInfoDal GeneralInfoDal,MemberInfo EntityPrimaryKeyMember):base(GeneralInfoDal,EntityPrimaryKeyMember)
        {
            _GeneralInfoDal = GeneralInfoDal;
        }
    }
}