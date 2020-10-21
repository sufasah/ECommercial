using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ShopManager : EntityServiceBase<Shop>,IShopService
    {
        private IShopDal _ShopDal;
        public ShopManager(IShopDal ShopDal,MemberInfo EntityPrimaryKeyMember):base(ShopDal,EntityPrimaryKeyMember)
        {
            _ShopDal = ShopDal;
        }
    }
}