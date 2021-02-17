using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class DistrictManager : EntityServiceBase<District>,IDistrictService
    {
        private readonly IDistrictDal _districtDal;
        private readonly IEntityDal<District> _entityDal;
        private readonly IMapper _mapper;
        public DistrictManager(IDistrictDal districtDal,IEntityDal<District> entityDal,IMapper mapper):base(districtDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _districtDal = districtDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override District Add(District Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(District Entity)
        {
            base.Delete(Entity);
        }

        public override List<District> GetAll()
        {
            return base.GetAll();
        }

        public override District Update(District Entity)
        {
            return base.Update(Entity);
        }
    }
}