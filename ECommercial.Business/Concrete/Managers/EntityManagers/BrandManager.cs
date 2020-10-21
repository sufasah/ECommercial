using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class BrandManager : EntityServiceBase<Brand>,IBrandService
    {
        private IBrandDal _BrandDal;
        public BrandManager(IBrandDal BrandDal,MemberInfo EntityPrimaryKeyMember):base(BrandDal,EntityPrimaryKeyMember)
        {
            _BrandDal = BrandDal;
        }
    }
}