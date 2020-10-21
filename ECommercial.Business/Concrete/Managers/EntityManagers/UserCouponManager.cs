using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserCouponManager : EntityServiceBase<UserCoupon>,IUserCouponService
    {
        private IUserCouponDal _userCouponDal;
        public UserCouponManager(IUserCouponDal UserCouponDal,MemberInfo EntityPrimaryKeyMember):base(UserCouponDal,EntityPrimaryKeyMember)
        {
            _userCouponDal = UserCouponDal;
        }
        public override UserCoupon Add(UserCoupon Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(UserCoupon Entity)
        {
            base.Delete(Entity);
        }

        public override List<UserCoupon> GetAll()
        {
            return base.GetAll();
        }

        public override UserCoupon Update(UserCoupon Entity)
        {
            return base.Update(Entity);
        }
    }
}