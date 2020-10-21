using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CityManager : EntityServiceBase<City>,ICityService
    {
        private ICityDal _cityDal;
        public CityManager(ICityDal CityDal,MemberInfo EntityPrimaryKeyMember):base(CityDal,EntityPrimaryKeyMember)
        {
            _cityDal = CityDal;
        }
        public override City Add(City Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(City Entity)
        {
            base.Delete(Entity);
        }

        public override List<City> GetAll()
        {
            return base.GetAll();
        }

        public override City Update(City Entity)
        {
            return base.Update(Entity);
        }
    }
}