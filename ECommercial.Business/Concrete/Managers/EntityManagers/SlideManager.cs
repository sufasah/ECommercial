using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SlideManager : EntityServiceBase<Slide>,ISlideService
    {
        private ISlideDal _slideDal;
        public SlideManager(ISlideDal SlideDal,MemberInfo EntityPrimaryKeyMember):base(SlideDal,EntityPrimaryKeyMember)
        {
            _slideDal = SlideDal;
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