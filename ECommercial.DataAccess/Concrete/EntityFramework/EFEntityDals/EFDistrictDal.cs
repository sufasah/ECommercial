
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using ECommercial.DataAccess.EntityFramework;
namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFDistrictDal : EFIEntityRepositoryBase<District,ECommercialContext>,IDistrictDal
    {
        
    }
}