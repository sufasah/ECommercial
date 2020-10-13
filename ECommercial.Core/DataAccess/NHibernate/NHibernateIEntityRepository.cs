using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.Core.Entities;

namespace ECommercial.Core.DataAccess.NHibernate
{
    public class NHibernateIEntityRepository<TEntity>:IEntityRepository<TEntity> 
        where TEntity:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;

        public NHibernateIEntityRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session=_nHibernateHelper.openSession()){
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session=_nHibernateHelper.openSession()){
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session=_nHibernateHelper.openSession()){
                TEntity result = session.Query<TEntity>().SingleOrDefault(filter);
                return result;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session=_nHibernateHelper.openSession()){
                if(filter==null)
                    return session.Query<TEntity>().ToList();
                List<TEntity> result = session.Query<TEntity>().Where(filter).ToList();
                return result;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session=_nHibernateHelper.openSession()){
                session.Update(entity);
                return entity;
            }
        }
    }
}