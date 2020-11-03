using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserCouponManager : EntityServiceBase<UserCoupon>,IUserCouponService
    {
        private IUserCouponDal _userCouponDal;
        private IEntityDal<UserCoupon> _entityDal;
        private IMapper _mapper;
        public UserCouponManager(IUserCouponDal userCouponDal,IEntityDal<UserCoupon> entityDal,IMapper mapper):base(userCouponDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _userCouponDal = userCouponDal;
            _entityDal=entityDal;
            _mapper=mapper;
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