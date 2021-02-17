using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ShopProductManager : EntityServiceBase<ShopProduct>,IShopProductService
    {
        private readonly IShopProductDal _shopProductDal;
        private readonly IEntityDal<ShopProduct> _entityDal;
        private readonly IMapper _mapper;
        public ShopProductManager(IShopProductDal shopProductDal,IEntityDal<ShopProduct> entityDal,IMapper mapper):base(shopProductDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _shopProductDal = shopProductDal;
            _entityDal=entityDal;
            _mapper=mapper;
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