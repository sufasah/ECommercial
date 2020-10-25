using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqCategoryManager : EntityServiceBase<FaqCategory>,IFaqCategoryService
    {
        private IFaqCategoryDal _faqCategoryDal;
        
        private IEntityDal<FaqCategory> _entityDal;
        public FaqCategoryManager(IFaqCategoryDal faqCategoryDal,IEntityDal<FaqCategory> entityDal):base(faqCategoryDal,entityDal.GetPrimaryKeyMember())
        {
            _faqCategoryDal = faqCategoryDal;
            _entityDal=entityDal;
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