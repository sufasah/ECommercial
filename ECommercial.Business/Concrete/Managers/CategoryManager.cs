using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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