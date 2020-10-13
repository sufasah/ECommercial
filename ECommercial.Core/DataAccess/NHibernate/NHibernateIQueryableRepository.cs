using System;
using System.Linq;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using ECommercial.Core.Entities;

namespace ECommercial.Core.DataAccess.NHibernate
{
    public class NHibernateIQueryableRepository<TEntity> : IQueryableRepository<TEntity>
    where TEntity : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<TEntity> _entities;

        public NHibernateIQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<TEntity> Table { get =>  this.Entities; }

        public virtual IQueryable<TEntity> Entities
        {
            get{
                if(_entities==null){
                    _entities = _nHibernateHelper.openSession().Query<TEntity>();
                }
                return _entities;
            }
        }
    }
}