using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class SubSubCategoryManager : EntityServiceBase<SubSubCategory>,ISubSubCategoryService
    {
        private ISubSubCategoryDal _SubSubCategoryDal;
        public SubSubCategoryManager(ISubSubCategoryDal SubSubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(SubSubCategoryDal,EntityPrimaryKeyMember)
        {
            _SubSubCategoryDal = SubSubCategoryDal;
        }
    }
}