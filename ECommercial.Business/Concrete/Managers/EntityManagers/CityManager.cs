using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CityManager : EntityServiceBase<City>,ICityService
    {
        private ICityDal _CityDal;
        public CityManager(ICityDal CityDal,MemberInfo EntityPrimaryKeyMember):base(CityDal,EntityPrimaryKeyMember)
        {
            _CityDal = CityDal;
        }
    }
}