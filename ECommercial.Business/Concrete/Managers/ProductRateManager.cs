using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class ProductRateManager : EntityServiceBase<ProductRate>,IProductRateService
    {
        private IProductRateDal _ProductRateDal;
        public ProductRateManager(IProductRateDal ProductRateDal,MemberInfo EntityPrimaryKeyMember):base(ProductRateDal,EntityPrimaryKeyMember)
        {
            _ProductRateDal = ProductRateDal;
        }
    }
}