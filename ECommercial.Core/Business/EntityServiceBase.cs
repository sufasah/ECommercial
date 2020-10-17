using System;
using System.Collections.Generic;
using ECommercial.Core.DataAccess;
using ECommercial.Core.Entities;

namespace ECommercial.Core.Business
{
    public class EntityServiceBase<TEntity> : IService<TEntity>
        where TEntity :class, IHasPrimaryKey<Nullable<Object>>,IEntity, new()
    {
        private IEntityRepository<TEntity> _entityRepository;

        public EntityServiceBase(IEntityRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public List<TEntity> GetAll()
        {
            return _entityRepository.GetList();
        }

        public TEntity GetByPrimaryKey(object key)
        {
            return _entityRepository.Get(o=>o.GetId()==key);
        }
    }
}