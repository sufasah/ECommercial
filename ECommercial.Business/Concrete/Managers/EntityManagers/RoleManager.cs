using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class RoleManager : EntityServiceBase<Role>,IRoleService
    {
        private readonly IRoleDal _roleDal;
        private readonly IEntityDal<Role> _entityDal;
        private readonly IMapper _mapper;
        public RoleManager(IRoleDal roleDal,IEntityDal<Role> entityDal,IMapper mapper):base(roleDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _roleDal = roleDal;
            _entityDal=entityDal;
            _mapper=mapper;
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