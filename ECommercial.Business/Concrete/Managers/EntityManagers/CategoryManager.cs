using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using System.Collections.Generic;
using AutoMapper;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class CategoryManager : EntityServiceBase<Category>,ICategoryService
    {
        private ICategoryDal _categoryDal;
        private IEntityDal<Category> _entityDal;
        private IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal,IEntityDal<Category> entityDal,IMapper mapper):base(categoryDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _categoryDal = categoryDal;
            _entityDal=entityDal;
            _mapper=mapper;
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