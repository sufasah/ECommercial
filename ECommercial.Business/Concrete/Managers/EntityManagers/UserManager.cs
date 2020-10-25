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
        private IEntityDal<User> _entityDal;
        public UserManager(IUserDal userDal,IEntityDal<User> entityDal):base(userDal,entityDal.GetPrimaryKeyMember())
        {
            _userDal = userDal;
            _entityDal=entityDal;
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