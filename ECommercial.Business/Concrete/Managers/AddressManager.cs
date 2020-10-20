using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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