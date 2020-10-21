using System.Reflection;
using ECommercial.DataAccess.Abstract;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
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