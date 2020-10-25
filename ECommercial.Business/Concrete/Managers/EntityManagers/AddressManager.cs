using System.Collections.Generic;
using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class AddressManager : EntityServiceBase<Address>,IAddressService
    {
        private IAddressDal _addressDal;
        private IEntityDal<Address> _entityDal;
        public AddressManager(IAddressDal AddressDal,IEntityDal<Address> entityDal):base(AddressDal,entityDal.GetPrimaryKeyMember())
        {
            _addressDal = AddressDal;
            _entityDal=entityDal;
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