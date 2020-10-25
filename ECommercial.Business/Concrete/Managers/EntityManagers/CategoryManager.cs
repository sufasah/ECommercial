using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CategoryManager : EntityServiceBase<Category>,ICategoryService
    {
        private ICategoryDal _categoryDal;
        private IEntityDal<Category> _entityDal;
        public CategoryManager(ICategoryDal categoryDal,IEntityDal<Category> entityDal):base(categoryDal,entityDal.GetPrimaryKeyMember())
        {
            _categoryDal = categoryDal;
            _entityDal=entityDal;
        }
        public override Category Add(Category Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Category Entity)
        {
            base.Delete(Entity);
        }

        public override List<Category> GetAll()
        {
            return base.GetAll();
        }

        public override Category Update(Category Entity)
        {
            return base.Update(Entity);
        }
    }
}