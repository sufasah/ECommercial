using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductRateManager : EntityServiceBase<ProductRate>,IProductRateService
    {
        private IProductRateDal _productRateDal;
        private IEntityDal<ProductRate> _entityDal;
        private IMapper _mapper;
        public ProductRateManager(IProductRateDal productRateDal,IEntityDal<ProductRate> entityDal,IMapper mapper):base(productRateDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _productRateDal = productRateDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override ProductRate Add(ProductRate Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(ProductRate Entity)
        {
            base.Delete(Entity);
        }

        public override List<ProductRate> GetAll()
        {
            return base.GetAll();
        }

        public override ProductRate Update(ProductRate Entity)
        {
            return base.Update(Entity);
        }
    }
}