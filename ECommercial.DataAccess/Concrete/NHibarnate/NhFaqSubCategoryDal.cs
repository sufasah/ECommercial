using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhFaqSubCategoryDal : NHibernateIEntityRepository<FaqSubCategory>, IFaqSubCategoryDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhFaqSubCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}