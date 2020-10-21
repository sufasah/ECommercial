using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CouponManager : EntityServiceBase<Coupon>,ICouponService
    {
        private ICouponDal _CouponDal;
        public CouponManager(ICouponDal CouponDal,MemberInfo EntityPrimaryKeyMember):base(CouponDal,EntityPrimaryKeyMember)
        {
            _CouponDal = CouponDal;
        }
    }
}