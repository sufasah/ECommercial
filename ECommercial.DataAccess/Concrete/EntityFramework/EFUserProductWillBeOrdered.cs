
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.EntityFramework
{
    public class EFUserProductWillBeOrdered : EFIEntityRepositoryBase<UserProductWillBeOrdered,ECommercialContext>,IUserProductWillBeOrderedDal
    {
        
    }
}