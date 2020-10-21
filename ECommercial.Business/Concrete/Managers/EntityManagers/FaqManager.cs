using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqManager : EntityServiceBase<Faq>,IFaqService
    {
        private IFaqDal _faqDal;
        public FaqManager(IFaqDal FaqDal,MemberInfo EntityPrimaryKeyMember):base(FaqDal,EntityPrimaryKeyMember)
        {
            _faqDal = FaqDal;
        }
        public override Faq Add(Faq Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Faq Entity)
        {
            base.Delete(Entity);
        }

        public override List<Faq> GetAll()
        {
            return base.GetAll();
        }

        public override Faq Update(Faq Entity)
        {
            return base.Update(Entity);
        }
    }
}