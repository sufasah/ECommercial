using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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