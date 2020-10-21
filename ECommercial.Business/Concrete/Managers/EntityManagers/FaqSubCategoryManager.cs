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
        public FaqSubCategoryManager(IFaqSubCategoryDal FaqSubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(FaqSubCategoryDal,EntityPrimaryKeyMember)
        {
            _faqSubCategoryDal = FaqSubCategoryDal;
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