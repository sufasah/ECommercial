using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class FaqCategoryManager : EntityServiceBase<FaqCategory>,IFaqCategoryService
    {
        private IFaqCategoryDal _FaqCategoryDal;
        public FaqCategoryManager(IFaqCategoryDal FaqCategoryDal,MemberInfo EntityPrimaryKeyMember):base(FaqCategoryDal,EntityPrimaryKeyMember)
        {
            _FaqCategoryDal = FaqCategoryDal;
        }
    }
}