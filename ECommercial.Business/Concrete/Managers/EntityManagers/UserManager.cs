using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserManager : EntityServiceBase<User>,IUserService
    {
        private IUserDal _UserDal;
        public UserManager(IUserDal UserDal,MemberInfo EntityPrimaryKeyMember):base(UserDal,EntityPrimaryKeyMember)
        {
            _UserDal = UserDal;
        }
    }
}