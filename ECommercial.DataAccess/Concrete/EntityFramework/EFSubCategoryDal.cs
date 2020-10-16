
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.EntityFramework
{
    public class EFSubCategoryDal : EFIEntityRepositoryBase<SubCategory,ECommercialContext>,ISubCategoryDal
    {
        
    }
}