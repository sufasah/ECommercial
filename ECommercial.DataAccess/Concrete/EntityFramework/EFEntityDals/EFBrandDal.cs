
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;
using ECommercial.DataAccess.EntityFramework;
namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFBrandDal : EFIEntityRepositoryBase<Brand,ECommercialContext>,IBrandDal
    {
        
    }
}