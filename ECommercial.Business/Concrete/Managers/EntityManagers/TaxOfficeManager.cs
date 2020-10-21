using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class TaxOfficeManager : EntityServiceBase<TaxOffice>,ITaxOfficeService
    {
        private ITaxOfficeDal _taxOfficeDal;
        public TaxOfficeManager(ITaxOfficeDal TaxOfficeDal,MemberInfo EntityPrimaryKeyMember):base(TaxOfficeDal,EntityPrimaryKeyMember)
        {
            _taxOfficeDal = TaxOfficeDal;
        }
        public override TaxOffice Add(TaxOffice Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(TaxOffice Entity)
        {
            base.Delete(Entity);
        }

        public override List<TaxOffice> GetAll()
        {
            return base.GetAll();
        }

        public override TaxOffice Update(TaxOffice Entity)
        {
            return base.Update(Entity);
        }
    }
}