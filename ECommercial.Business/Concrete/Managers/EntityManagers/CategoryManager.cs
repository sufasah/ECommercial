using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CategoryManager : EntityServiceBase<Category>,ICategoryService
    {
        private ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal CategoryDal,MemberInfo EntityPrimaryKeyMember):base(CategoryDal,EntityPrimaryKeyMember)
        {
            _CategoryDal = CategoryDal;
        }
    }
}