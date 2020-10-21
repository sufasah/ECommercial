using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class DistrictManager : EntityServiceBase<District>,IDistrictService
    {
        private IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal DistrictDal,MemberInfo EntityPrimaryKeyMember):base(DistrictDal,EntityPrimaryKeyMember)
        {
            _districtDal = DistrictDal;
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