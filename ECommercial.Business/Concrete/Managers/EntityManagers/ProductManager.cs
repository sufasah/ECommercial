using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using System.Collections.Generic;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;
using ECommercial.Core.Aspects.PostSharp.ValidationAspects.FluentValidation;
using AutoMapper;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductManager : EntityServiceBase<Product>,IProductService
    {
        private IProductDal _productDal;
        private IEntityDal<Product> _entityDal;
        private IMapper _mapper;
        public ProductManager(IProductDal productDal,IEntityDal<Product> entityDal,IMapper mapper):base(productDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _productDal = productDal;
            _entityDal=entityDal;
            _mapper=mapper;
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