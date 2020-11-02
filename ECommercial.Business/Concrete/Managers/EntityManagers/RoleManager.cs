using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class RoleManager : EntityServiceBase<Role>,IRoleService
    {
        private IRoleDal _roleDal;
        private IEntityDal<Role> _entityDal;
        public RoleManager(IRoleDal roleDal,IEntityDal<Role> entityDal):base(roleDal,entityDal.GetPrimaryKeyMember())
        {
            _roleDal = roleDal;
            _entityDal=entityDal;
        }
        public override Role Add(Role Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Role Entity)
        {
            base.Delete(Entity);
        }

        public override List<Role> GetAll()
        {
            return base.GetAll();
        }

        public override Role Update(Role Entity)
        {
            return base.Update(Entity);
        }
    }
}