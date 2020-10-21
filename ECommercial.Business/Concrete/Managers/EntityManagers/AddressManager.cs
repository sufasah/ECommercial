using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class AddressManager : EntityServiceBase<Address>,IAddressService
    {
        private IAddressDal _AddressDal;
        public AddressManager(IAddressDal AddressDal,MemberInfo EntityPrimaryKeyMember):base(AddressDal,EntityPrimaryKeyMember)
        {
            _AddressDal = AddressDal;
        }
    }
}