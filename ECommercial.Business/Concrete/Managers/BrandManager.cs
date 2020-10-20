using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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