using System.Linq;
using ECommercial.Core.Entities;

namespace ECommercial.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class ,IEntity,new()
    {
         IQueryable<T> Table {get;}
    }
}