using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqSubCategoryManager : EntityServiceBase<FaqSubCategory>,IFaqSubCategoryService
    { 
        private readonly IFaqSubCategoryDal _faqSubCategoryDal;
        private readonly IEntityDal<FaqSubCategory> _entityDal;
        private readonly IMapper _mapper;
        public FaqSubCategoryManager(IFaqSubCategoryDal faqSubCategoryDal,IEntityDal<FaqSubCategory> entityDal,IMapper mapper):base(faqSubCategoryDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _faqSubCategoryDal = faqSubCategoryDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override FaqSubCategory Add(FaqSubCategory Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(FaqSubCategory Entity)
        {
            base.Delete(Entity);
        }

        public override List<FaqSubCategory> GetAll()
        {
            return base.GetAll();
        }

        public override FaqSubCategory Update(FaqSubCategory Entity)
        {
            return base.Update(Entity);
        }
    }
}