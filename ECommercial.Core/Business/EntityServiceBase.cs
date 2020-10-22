using System.Reflection;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using ECommercial.Core.DataAccess;
using ECommercial.Core.Entities;

namespace ECommercial.Core.Business
{
    public abstract class EntityServiceBase<TEntity> : IService<TEntity>
        where TEntity :class,IEntity, new()
    {
        private IEntityRepository<TEntity> _entityRepository;
        private MemberInfo _entityPrimaryKeyMember;
        
        protected EntityServiceBase(IEntityRepository<TEntity> entityRepository, MemberInfo entityPrimaryKeyMember)
        {
            _entityRepository = entityRepository;
            _entityPrimaryKeyMember = entityPrimaryKeyMember;
        }

        public virtual TEntity Add(TEntity Entity)
        {
            return _entityRepository.Add(Entity);
        }

        public virtual void Delete(TEntity Entity)
        {
            _entityRepository.Delete(Entity);
        }

        public virtual List<TEntity> GetAll()
        {
            return _entityRepository.GetList();
        }

        public virtual TEntity GetByPrimaryKey(Object key)
        {
            if(_entityPrimaryKeyMember==null)
                throw new KeyNotFoundException($"For {typeof(TEntity).Name} Class, There is any memberfield that infer primary key of the class when instantiating service.");
            var param = Expression.Parameter(typeof(TEntity),"e");
            Expression<Func<TEntity,bool>> filter = Expression.Lambda<Func<TEntity,bool>>(
                Expression.Call(
                    Expression.MakeMemberAccess(param,_entityPrimaryKeyMember),
                    typeof(TEntity).GetMethod("Equals"),
                    Expression.Constant(Expression.Convert(Expression.Constant(key),typeof(Object)))
                ),
                param
            );
            return _entityRepository.Get(filter);
        }

        public virtual TEntity Update(TEntity Entity)
        {
            return _entityRepository.Update(Entity);
        }
    }
}