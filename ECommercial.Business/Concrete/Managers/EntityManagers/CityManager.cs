using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CityManager : EntityServiceBase<City>,ICityService
    {
        private ICityDal _cityDal;
        private IEntityDal<City> _entityDal;
        private IMapper _mapper;
        public CityManager(ICityDal cityDal,IEntityDal<City> entityDal,IMapper mapper):base(cityDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _cityDal = cityDal;
            _entityDal=entityDal;
            _mapper=mapper;
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