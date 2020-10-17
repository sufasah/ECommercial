using System.Collections.Generic;
using ECommercial.Business.Abstract;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class IProductManager : IProductService
    {
        private IProductDal _productDal;

        public IProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetByPrimaryKey(object key)
        {
            throw new System.NotImplementedException();
        }
    }
}