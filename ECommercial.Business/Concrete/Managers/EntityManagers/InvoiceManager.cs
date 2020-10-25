using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class InvoiceManager : EntityServiceBase<Invoice>,IInvoiceService
    {
        private IInvoiceDal _invoiceDal;
        private IEntityDal<Invoice> _entityDal;
        public InvoiceManager(IInvoiceDal invoiceDal,IEntityDal<Invoice> entityDal):base(invoiceDal,entityDal.GetPrimaryKeyMember())
        {
            _invoiceDal = invoiceDal;
            _entityDal=entityDal;
        }
        public override Invoice Add(Invoice Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Invoice Entity)
        {
            base.Delete(Entity);
        }

        public override List<Invoice> GetAll()
        {
            return base.GetAll();
        }

        public override Invoice Update(Invoice Entity)
        {
            return base.Update(Entity);
        }
    }
}