
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entites.concrete;

namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFAddressDal : EFIEntityRepositoryBase<Address,ECommercialContext>,IAddressDal
    {
        
    }
}