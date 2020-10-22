using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using System.Collections.Generic;
using ECommercial.Core.Aspects.PostSharp;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductManager : EntityServiceBase<Product>,IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal,MemberInfo EntityPrimaryKeyMember):base(productDal,EntityPrimaryKeyMember)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public override Product Add(Product Entity)
        {
            return base.Add(Entity);
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        public override void Delete(Product Entity)
        {
            base.Delete(Entity);
        }

        public override List<Product> GetAll()
        {
            return base.GetAll();
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public override Product Update(Product Entity)
        {
            return base.Update(Entity);
        }
    }
}