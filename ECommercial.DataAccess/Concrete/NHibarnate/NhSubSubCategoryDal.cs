using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhSubSubCategoryDal : NHibernateIEntityRepository<SubSubCategory>, ISubSubCategoryDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhSubSubCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}