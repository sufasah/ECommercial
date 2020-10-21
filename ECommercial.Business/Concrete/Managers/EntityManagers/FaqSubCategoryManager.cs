using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class FaqSubCategoryManager : EntityServiceBase<FaqSubCategory>,IFaqSubCategoryService
    {
        private IFaqSubCategoryDal _FaqSubCategoryDal;
        public FaqSubCategoryManager(IFaqSubCategoryDal FaqSubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(FaqSubCategoryDal,EntityPrimaryKeyMember)
        {
            _FaqSubCategoryDal = FaqSubCategoryDal;
        }
    }
}