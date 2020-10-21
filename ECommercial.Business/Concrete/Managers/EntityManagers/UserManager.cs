using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserManager : EntityServiceBase<User>,IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal UserDal,MemberInfo EntityPrimaryKeyMember):base(UserDal,EntityPrimaryKeyMember)
        {
            _userDal = UserDal;
        }
        public override User Add(User Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(User Entity)
        {
            base.Delete(Entity);
        }

        public override List<User> GetAll()
        {
            return base.GetAll();
        }

        public override User Update(User Entity)
        {
            return base.Update(Entity);
        }
    }
}