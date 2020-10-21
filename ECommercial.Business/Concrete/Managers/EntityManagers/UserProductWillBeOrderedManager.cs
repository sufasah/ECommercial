using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserProductWillBeOrderedManager : EntityServiceBase<UserProductWillBeOrdered>,IUserProductWillBeOrderedService
    {
        private IUserProductWillBeOrderedDal _UserProductWillBeOrderedDal;
        public UserProductWillBeOrderedManager(IUserProductWillBeOrderedDal UserProductWillBeOrderedDal,MemberInfo EntityPrimaryKeyMember):base(UserProductWillBeOrderedDal,EntityPrimaryKeyMember)
        {
            _UserProductWillBeOrderedDal = UserProductWillBeOrderedDal;
        }
    }
}