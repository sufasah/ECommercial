using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqManager : EntityServiceBase<Faq>,IFaqService
    {
        private IFaqDal _FaqDal;
        public FaqManager(IFaqDal FaqDal,MemberInfo EntityPrimaryKeyMember):base(FaqDal,EntityPrimaryKeyMember)
        {
            _FaqDal = FaqDal;
        }
    }
}