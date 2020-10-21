using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SlideManager : EntityServiceBase<Slide>,ISlideService
    {
        private ISlideDal _SlideDal;
        public SlideManager(ISlideDal SlideDal,MemberInfo EntityPrimaryKeyMember):base(SlideDal,EntityPrimaryKeyMember)
        {
            _SlideDal = SlideDal;
        }
    }
}