
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.EntityFramework
{
    public class EFAddressDal : EFIEntityRepositoryBase<Address,ECommercialContext>,IAddressDal
    {
        
    }
}