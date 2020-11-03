using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SlideManager : EntityServiceBase<Slide>,ISlideService
    {
        private ISlideDal _slideDal;
        private IEntityDal<Slide> _entityDal;
        private IMapper _mapper;
        public SlideManager(ISlideDal slideDal,IEntityDal<Slide> entityDal,IMapper mapper):base(slideDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _slideDal = slideDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override Slide Add(Slide Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Slide Entity)
        {
            base.Delete(Entity);
        }

        public override List<Slide> GetAll()
        {
            return base.GetAll();
        }

        public override Slide Update(Slide Entity)
        {
            return base.Update(Entity);
        }
    }
}