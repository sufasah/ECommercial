using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductManager : EntityServiceBase<Product>,IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal,MemberInfo EntityPrimaryKeyMember):base(productDal,EntityPrimaryKeyMember)
        {
            _productDal = productDal;
        }
    }
}