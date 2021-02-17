using System.Reflection;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using ECommercial.Core.DataAccess;
using ECommercial.Core.Entities;
using AutoMapper;
using ECommercial.Core.Utilities.Mappings;

namespace ECommercial.Core.Business
{
    public abstract class EntityServiceBase<TEntity> : IService<TEntity>
        where TEntity :class,IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _entityRepository;
        private readonly MemberInfo _entityPrimaryKeyMember;
        private readonly IMapper _mapper;
        protected EntityServiceBase(IEntityRepository<TEntity> entityRepository, MemberInfo entityPrimaryKeyMember,IMapper mapper)
        {
            _entityRepository = entityRepository;
            _entityPrimaryKeyMember = entityPrimaryKeyMember;
            _mapper=mapper;
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
            var entities = _mapper.Map<List<TEntity>>(_entityRepository.GetList());
            return entities;
        }

        public virtual TEntity GetByPrimaryKey(Object key)
        {
            if(_entityPrimaryKeyMember==null)
                throw new KeyNotFoundException($"For {typeof(TEntity).Name} Class, There is any memberfield that infer primary key of the class when instantiating service.");
            var param = Expression.Parameter(typeof(TEntity),"e");
            Expression<Func<TEntity,bool>> filter = Expression.Lambda<Func<TEntity,bool>>(
                Expression.Or(
                    Expression.Call(
                        Expression.MakeMemberAccess(param,_entityPrimaryKeyMember),
                        typeof(TEntity).GetMethod("Equals"),
                        Expression.Constant(Expression.Convert(Expression.Constant(key),typeof(Object)))
                    ),
                    Expression.Equal(
                        Expression.Call(
                            Expression.MakeMemberAccess(param,_entityPrimaryKeyMember),
                            typeof(TEntity).GetMethod("ToString",Type.EmptyTypes),
                            null
                        ),
                        Expression.Call(
                            Expression.Constant(key),
                            key.GetType().GetMethod("ToString",Type.EmptyTypes),
                            null
                        )
                    )
                ),
                param
            );// entity => entity.Equals(key) || entity.ToString()==key.ToString()
            return _entityRepository.Get(filter);
        }

        public virtual TEntity Update(TEntity Entity)
        {
            return _entityRepository.Update(Entity);
        }

        

    }
}