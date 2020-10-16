using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhUserProductWillBeOrdered : NHibernateIEntityRepository<UserProductWillBeOrdered>, IUserProductWillBeOrderedDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhUserProductWillBeOrdered(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}