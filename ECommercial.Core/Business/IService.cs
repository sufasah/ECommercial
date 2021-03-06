using System;
using System.Collections.Generic;
using ECommercial.Core.Entities;

namespace ECommercial.Core.Business
{
    public interface IService<T> where T:class,IEntity,new()
    {
         List<T> GetAll();

         T GetByPrimaryKey(Object key);

         T Add(T Entity);

         T Update(T Entity);

         void Delete(T Entity);

    }
}