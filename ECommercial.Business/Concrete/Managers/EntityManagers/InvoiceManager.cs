using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class InvoiceManager : EntityServiceBase<Invoice>,IInvoiceService
    {
        private IInvoiceDal _InvoiceDal;
        public InvoiceManager(IInvoiceDal InvoiceDal,MemberInfo EntityPrimaryKeyMember):base(InvoiceDal,EntityPrimaryKeyMember)
        {
            _InvoiceDal = InvoiceDal;
        }
    }
}