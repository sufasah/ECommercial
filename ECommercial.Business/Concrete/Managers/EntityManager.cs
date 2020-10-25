using System.Reflection;
using ECommercial.Core.Entities;
using ECommercial.DataAccess.Abstract.AbstractEntities;

namespace ECommercial.Business.Concrete.Managers
{
    public class EntityManager<TEntity>
        where TEntity:class,IEntity,new()
    {
        private IEntityDal<TEntity> _entityDal;

        public EntityManager(IEntityDal<TEntity> entityDal)
        {
            _entityDal = entityDal;
        }

        public MemberInfo GetPrimaryKeyMember()
        {
            return _entityDal.GetPrimaryKeyMember();
        }
    }
}