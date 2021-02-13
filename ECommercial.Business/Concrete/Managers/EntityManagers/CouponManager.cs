using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using System.Collections.Generic;
using AutoMapper;
namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CouponManager : EntityServiceBase<Coupon>,ICouponService
    {
        private ICouponDal _couponDal;
        private IEntityDal<Coupon> _entityDal;
        private IMapper _mapper;
        public CouponManager(ICouponDal couponDal,IEntityDal<Coupon> entityDal,IMapper mapper):base(couponDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _couponDal = couponDal;
            _entityDal=entityDal;
            _mapper=mapper;
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