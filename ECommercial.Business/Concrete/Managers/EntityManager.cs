using System.Reflection;
using ECommercial.DataAccess.Abstract.AbstractEntities;

namespace ECommercial.Business.Concrete.Managers
{
    public class EntityManager
    {
        private IEntityDal _entityDal;

        public EntityManager(IEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public MemberInfo GetPrimaryKeyMember()
        {
            return _entityDal.GetPrimaryKeyMember();
        }
    }
}