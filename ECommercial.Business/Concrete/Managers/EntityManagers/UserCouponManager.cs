using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
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