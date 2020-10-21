using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SubCategoryManager : EntityServiceBase<SubCategory>,ISubCategoryService
    {
        private ISubCategoryDal _SubCategoryDal;
        public SubCategoryManager(ISubCategoryDal SubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(SubCategoryDal,EntityPrimaryKeyMember)
        {
            _SubCategoryDal = SubCategoryDal;
        }
    }
}