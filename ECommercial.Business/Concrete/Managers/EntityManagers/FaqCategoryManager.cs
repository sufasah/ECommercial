using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqCategoryManager : EntityServiceBase<FaqCategory>,IFaqCategoryService
    {
        private readonly IFaqCategoryDal _faqCategoryDal;
        
        private readonly IEntityDal<FaqCategory> _entityDal;
        private readonly IMapper _mapper;
        public FaqCategoryManager(IFaqCategoryDal faqCategoryDal,IEntityDal<FaqCategory> entityDal,IMapper mapper):base(faqCategoryDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _faqCategoryDal = faqCategoryDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override FaqCategory Add(FaqCategory Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(FaqCategory Entity)
        {
            base.Delete(Entity);
        }

        public override List<FaqCategory> GetAll()
        {
            return base.GetAll();
        }

        public override FaqCategory Update(FaqCategory Entity)
        {
            return base.Update(Entity);
        }
    }
}