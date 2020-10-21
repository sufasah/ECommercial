using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
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