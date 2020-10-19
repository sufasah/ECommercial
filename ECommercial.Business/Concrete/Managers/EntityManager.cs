using System.Reflection;
using ECommercial.Core.Entities;
using ECommercial.DataAccess.Abstract;

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