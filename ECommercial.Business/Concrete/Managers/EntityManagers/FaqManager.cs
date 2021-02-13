using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqManager : EntityServiceBase<Faq>,IFaqService
    {
        private IFaqDal _faqDal;
        private IEntityDal<Faq> _entityDal;
        private IMapper _mapper;
        public FaqManager(IFaqDal faqDal,IEntityDal<Faq> entityDal,IMapper mapper):base(faqDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _faqDal = faqDal;
            _entityDal=entityDal;
            _mapper=mapper;
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