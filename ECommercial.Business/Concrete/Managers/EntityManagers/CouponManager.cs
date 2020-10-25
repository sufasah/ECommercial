using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CouponManager : EntityServiceBase<Coupon>,ICouponService
    {
        private ICouponDal _couponDal;
        private IEntityDal<Coupon> _entityDal;
        public CouponManager(ICouponDal couponDal,IEntityDal<Coupon> entityDal):base(couponDal,entityDal.GetPrimaryKeyMember())
        {
            _couponDal = couponDal;
            _entityDal=entityDal;
        }
        public override Coupon Add(Coupon Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Coupon Entity)
        {
            base.Delete(Entity);
        }

        public override List<Coupon> GetAll()
        {
            return base.GetAll();
        }

        public override Coupon Update(Coupon Entity)
        {
            return base.Update(Entity);
        }
    }
}