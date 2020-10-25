using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductRateManager : EntityServiceBase<ProductRate>,IProductRateService
    {
        private IProductRateDal _productRateDal;
        private IEntityDal<ProductRate> _entityDal;
        public ProductRateManager(IProductRateDal productRateDal,IEntityDal<ProductRate> entityDal):base(productRateDal,entityDal.GetPrimaryKeyMember())
        {
            _productRateDal = productRateDal;
            _entityDal=entityDal;
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