using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhProductDal : NHibernateIEntityRepository<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;

        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

    }
}