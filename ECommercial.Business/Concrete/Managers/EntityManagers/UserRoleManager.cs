using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserRoleManager : EntityServiceBase<UserRole>,IUserRoleService
    {
        private IUserRoleDal _userRoleDal;
        private IEntityDal<UserRole> _entityDal;
        public UserRoleManager(IUserRoleDal userRoleDal,IEntityDal<UserRole> entityDal):base(userRoleDal,entityDal.GetPrimaryKeyMember())
        {
            _userRoleDal = userRoleDal;
            _entityDal=entityDal;
        }
        public override UserRole Add(UserRole Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(UserRole Entity)
        {
            base.Delete(Entity);
        }

        public override List<UserRole> GetAll()
        {
            return base.GetAll();
        }

        public override UserRole Update(UserRole Entity)
        {
            return base.Update(Entity);
        }
    }
}