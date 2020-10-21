using ECommercial.Core.DataAccess.NHibernate;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.NHibarnate
{
    public class NhTaxOfficeDal : NHibernateIEntityRepository<TaxOffice>, ITaxOfficeDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhTaxOfficeDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        
    }
}