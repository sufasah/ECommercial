using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class UserCouponManager : EntityServiceBase<UserCoupon>,IUserCouponService
    {
        private IUserCouponDal _UserCouponDal;
        public UserCouponManager(IUserCouponDal UserCouponDal,MemberInfo EntityPrimaryKeyMember):base(UserCouponDal,EntityPrimaryKeyMember)
        {
            _UserCouponDal = UserCouponDal;
        }
    }
}