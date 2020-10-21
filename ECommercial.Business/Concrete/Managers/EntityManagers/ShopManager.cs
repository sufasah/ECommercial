using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ShopManager : EntityServiceBase<Shop>,IShopService
    {
        private IShopDal _shopDal;
        public ShopManager(IShopDal ShopDal,MemberInfo EntityPrimaryKeyMember):base(ShopDal,EntityPrimaryKeyMember)
        {
            _shopDal = ShopDal;
        }
        public override Shop Add(Shop Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Shop Entity)
        {
            base.Delete(Entity);
        }

        public override List<Shop> GetAll()
        {
            return base.GetAll();
        }

        public override Shop Update(Shop Entity)
        {
            return base.Update(Entity);
        }
    }
}