using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using System.Collections.Generic;
using AutoMapper;
namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class BrandManager : EntityServiceBase<Brand>,IBrandService
    {
        private IBrandDal _brandDal;
        private IEntityDal<Brand> _entityDal;
        private IMapper _mapper;
        public BrandManager(IBrandDal brandDal,IEntityDal<Brand> entityDal,IMapper mapper):base(brandDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _brandDal = brandDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override Brand Add(Brand Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Brand Entity)
        {
            base.Delete(Entity);
        }

        public override List<Brand> GetAll()
        {
            return base.GetAll();
        }

        public override Brand Update(Brand Entity)
        {
            return base.Update(Entity);
        }
    }
}