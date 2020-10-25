using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqSubCategoryManager : EntityServiceBase<FaqSubCategory>,IFaqSubCategoryService
    {
        private IFaqSubCategoryDal _faqSubCategoryDal;
        private IEntityDal<FaqSubCategory> _entityDal;
        public FaqSubCategoryManager(IFaqSubCategoryDal faqSubCategoryDal,IEntityDal<FaqSubCategory> entityDal):base(faqSubCategoryDal,entityDal.GetPrimaryKeyMember())
        {
            _faqSubCategoryDal = faqSubCategoryDal;
            _entityDal=entityDal;
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