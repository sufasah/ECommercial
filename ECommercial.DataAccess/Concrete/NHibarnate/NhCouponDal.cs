using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhCouponDal : NHibernateIEntityRepository<Coupon>, ICouponDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhCouponDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}