using System.Linq;
using System.Reflection;
using ECommercial.Core.Entities;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ECommercial.DataAccess.Concrete.EntityFramework
{
    public class EFEntityDal<TEntity> : IEntityDal
        where TEntity:class,IEntity,new()
    {
        private DbContext _context;

        public EFEntityDal(DbContext context)
        {
            _context = context;
        }

        public MemberInfo GetPrimaryKeyMember()
        {

            IEntityType entityType=_context.Model.GetEntityTypes().FirstOrDefault(t=>t.ClrType==typeof(TEntity));
            
            if(entityType ==default(IEntityType))
                throw new TargetException($"There is no such a given entity in {_context.GetType().Name} context");
            
            IKey key =entityType.FindPrimaryKey();
            if(key==null)
                return null;
            return (MemberInfo)key.Properties[0].PropertyInfo??key.Properties[0].FieldInfo;// If always there pk property this should work fine without firstordefault()
        }
    }
}