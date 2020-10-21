using System.Collections.Generic;
using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class AddressManager : EntityServiceBase<Address>,IAddressService
    {
        private IAddressDal _addressDal;
        public AddressManager(IAddressDal AddressDal,MemberInfo EntityPrimaryKeyMember):base(AddressDal,EntityPrimaryKeyMember)
        {
            _addressDal = AddressDal;
        }
        public override Address Add(Address Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Address Entity)
        {
            base.Delete(Entity);
        }

        public override List<Address> GetAll()
        {
            return base.GetAll();
        }

        public override Address Update(Address Entity)
        {
            return base.Update(Entity);
        }
    }
}