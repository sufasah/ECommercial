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
        public SubSubCategoryManager(ISubSubCategoryDal SubSubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(SubSubCategoryDal,EntityPrimaryKeyMember)
        {
            _subSubCategoryDal = SubSubCategoryDal;
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