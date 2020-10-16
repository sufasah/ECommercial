
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.EntityFramework
{
    public class EFUserDal : EFIEntityRepositoryBase<User,ECommercialContext>,IUserDal
    {
        
    }
}