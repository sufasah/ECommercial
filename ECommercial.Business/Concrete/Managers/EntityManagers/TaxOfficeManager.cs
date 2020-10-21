using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class TaxOfficeManager : EntityServiceBase<TaxOffice>,ITaxOfficeService
    {
        private ITaxOfficeDal _TaxOfficeDal;
        public TaxOfficeManager(ITaxOfficeDal TaxOfficeDal,MemberInfo EntityPrimaryKeyMember):base(TaxOfficeDal,EntityPrimaryKeyMember)
        {
            _TaxOfficeDal = TaxOfficeDal;
        }
    }
}