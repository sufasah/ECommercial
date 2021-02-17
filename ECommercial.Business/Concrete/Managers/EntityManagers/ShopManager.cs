using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ShopManager : EntityServiceBase<Shop>,IShopService
    {
        private readonly IShopDal _shopDal;
        private readonly IEntityDal<Shop> _entityDal;
        private readonly IMapper _mapper;
        public ShopManager(IShopDal shopDal,IEntityDal<Shop> entityDal,IMapper mapper):base(shopDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _shopDal = shopDal;
            _entityDal=entityDal;
            _mapper=mapper;
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