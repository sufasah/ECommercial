using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ShopProductManager : EntityServiceBase<ShopProduct>,IShopProductService
    {
        private IShopProductDal _shopProductDal;
        private IEntityDal<ShopProduct> _entityDal;
        public ShopProductManager(IShopProductDal shopProductDal,IEntityDal<ShopProduct> entityDal):base(shopProductDal,entityDal.GetPrimaryKeyMember())
        {
            _shopProductDal = shopProductDal;
            _entityDal=entityDal;
        }
        public override ShopProduct Add(ShopProduct Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(ShopProduct Entity)
        {
            base.Delete(Entity);
        }

        public override List<ShopProduct> GetAll()
        {
            return base.GetAll();
        }

        public override ShopProduct Update(ShopProduct Entity)
        {
            return base.Update(Entity);
        }
    }
}