using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using System.Collections.Generic;
using AutoMapper;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductManager : EntityServiceBase<Product>,IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IEntityDal<Product> _entityDal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal,IEntityDal<Product> entityDal,IMapper mapper):base(productDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _productDal = productDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }

        public override Product Add(Product Entity)
        {
            return base.Add(Entity);
        }
        public override void Delete(Product Entity)
        {
            base.Delete(Entity);
        }

        public override List<Product> GetAll()
        {
            return base.GetAll();
        }

        public override Product Update(Product Entity)
        {
            return base.Update(Entity);
        }
    }
}