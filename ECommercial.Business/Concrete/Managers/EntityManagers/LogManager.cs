using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class LogManager : EntityServiceBase<Log>,ILogService
    {
        private ILogDal _logDal;
        private IEntityDal<Log> _entityDal;
        public LogManager(ILogDal logDal,IEntityDal<Log> entityDal):base(logDal,entityDal.GetPrimaryKeyMember())
        {
            _logDal = logDal;
            _entityDal=entityDal;
        }
        public override Log Add(Log Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Log Entity)
        {
            base.Delete(Entity);
        }

        public override List<Log> GetAll()
        {
            return base.GetAll();
        }

        public override Log Update(Log Entity)
        {
            return base.Update(Entity);
        }
    }
}