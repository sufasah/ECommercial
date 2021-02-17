using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class LogManager : EntityServiceBase<Log>,ILogService
    {
        private readonly ILogDal _logDal;
        private readonly IEntityDal<Log> _entityDal;
        private readonly IMapper _mapper;
        public LogManager(ILogDal logDal,IEntityDal<Log> entityDal,IMapper mapper):base(logDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _logDal = logDal;
            _entityDal=entityDal;
            _mapper=mapper;
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