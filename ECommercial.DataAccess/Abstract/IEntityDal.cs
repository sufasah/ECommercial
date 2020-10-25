using System.Reflection;
using ECommercial.Core.Entities;

namespace ECommercial.DataAccess.Abstract.AbstractEntities
{
    public interface IEntityDal<TEntity>
        where TEntity:class,IEntity,new()
    {
        MemberInfo GetPrimaryKeyMember();
    }
}