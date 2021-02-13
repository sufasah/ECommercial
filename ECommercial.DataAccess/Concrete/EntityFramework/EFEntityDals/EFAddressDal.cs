
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entities.concrete;

namespace ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals
{
    public class EFAddressDal : EFEntityRepositoryBase<Address,ECommercialContext>,IAddressDal
    {
        
    }
}