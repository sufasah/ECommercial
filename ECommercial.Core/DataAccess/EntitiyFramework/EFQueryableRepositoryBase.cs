using System.Linq;
using ECommercial.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.Core.DataAccess.EntitiyFramework
{
    public class EFQueryableRepositoryBase<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        private DbSet<TEntity> _entities;
        public EFQueryableRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> Table{
            get{
                return this.Entities;
            }
        }
        protected virtual DbSet<TEntity> Entities{
            get{
                if(_entities==null){
                    _entities = _context.Set<TEntity>();
                }
                return _entities;
            }
        }
    }
}