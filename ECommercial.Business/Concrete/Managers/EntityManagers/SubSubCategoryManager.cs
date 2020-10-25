using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SubSubCategoryManager : EntityServiceBase<SubSubCategory>,ISubSubCategoryService
    {
        private ISubSubCategoryDal _subSubCategoryDal;
        private IEntityDal<SubSubCategory> _entityDal;
        public SubSubCategoryManager(ISubSubCategoryDal subSubCategoryDal,IEntityDal<SubSubCategory> entityDal):base(subSubCategoryDal,entityDal.GetPrimaryKeyMember())
        {
            _subSubCategoryDal = subSubCategoryDal;
            _entityDal=entityDal;
        }
        public override SubSubCategory Add(SubSubCategory Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(SubSubCategory Entity)
        {
            base.Delete(Entity);
        }

        public override List<SubSubCategory> GetAll()
        {
            return base.GetAll();
        }

        public override SubSubCategory Update(SubSubCategory Entity)
        {
            return base.Update(Entity);
        }
    }
}