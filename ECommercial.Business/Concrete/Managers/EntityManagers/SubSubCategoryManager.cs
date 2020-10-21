using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
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