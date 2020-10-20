using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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