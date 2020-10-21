using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class DistrictManager : EntityServiceBase<District>,IDistrictService
    {
        private IDistrictDal _DistrictDal;
        public DistrictManager(IDistrictDal DistrictDal,MemberInfo EntityPrimaryKeyMember):base(DistrictDal,EntityPrimaryKeyMember)
        {
            _DistrictDal = DistrictDal;
        }
    }
}