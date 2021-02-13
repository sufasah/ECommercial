
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using ECommercial.DataAccess.EntityFramework;
namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFUserCouponDal : EFEntityRepositoryBase<UserCoupon,ECommercialContext>,IUserCouponDal
    {
        
    }
}