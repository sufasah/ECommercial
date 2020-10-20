using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class ShopProductManager : EntityServiceBase<ShopProduct>,IShopProductService
    {
        private IShopProductDal _ShopProductDal;
        public ShopProductManager(IShopProductDal ShopProductDal,MemberInfo EntityPrimaryKeyMember):base(ShopProductDal,EntityPrimaryKeyMember)
        {
            _ShopProductDal = ShopProductDal;
        }
    }
}