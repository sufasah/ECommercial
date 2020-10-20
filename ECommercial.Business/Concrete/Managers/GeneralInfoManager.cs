using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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