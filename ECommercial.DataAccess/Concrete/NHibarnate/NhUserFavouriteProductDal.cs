using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhUserFavouriteProductDal : NHibernateIEntityRepository<UserFavouriteProduct>, IUserFavouriteProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhUserFavouriteProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}