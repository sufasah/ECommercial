using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserProductWillBeOrderedManager : EntityServiceBase<UserProductWillBeOrdered>,IUserProductWillBeOrderedService
    {
        private IUserProductWillBeOrderedDal _userProductWillBeOrderedDal;
        private IEntityDal<UserProductWillBeOrdered> _entityDal;
        private IMapper _mapper;
        public UserProductWillBeOrderedManager(IUserProductWillBeOrderedDal userProductWillBeOrderedDal,IEntityDal<UserProductWillBeOrdered> entityDal,IMapper mapper):base(userProductWillBeOrderedDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _userProductWillBeOrderedDal = userProductWillBeOrderedDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override UserProductWillBeOrdered Add(UserProductWillBeOrdered Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(UserProductWillBeOrdered Entity)
        {
            base.Delete(Entity);
        }

        public override List<UserProductWillBeOrdered> GetAll()
        {
            return base.GetAll();
        }

        public override UserProductWillBeOrdered Update(UserProductWillBeOrdered Entity)
        {
            return base.Update(Entity);
        }
    }
}