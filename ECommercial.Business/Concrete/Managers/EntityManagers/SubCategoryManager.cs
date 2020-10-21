using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SubCategoryManager : EntityServiceBase<SubCategory>,ISubCategoryService
    {
        private ISubCategoryDal _subCategoryDal;
        public SubCategoryManager(ISubCategoryDal SubCategoryDal,MemberInfo EntityPrimaryKeyMember):base(SubCategoryDal,EntityPrimaryKeyMember)
        {
            _subCategoryDal = SubCategoryDal;
        }
        public override SubCategory Add(SubCategory Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(SubCategory Entity)
        {
            base.Delete(Entity);
        }

        public override List<SubCategory> GetAll()
        {
            return base.GetAll();
        }

        public override SubCategory Update(SubCategory Entity)
        {
            return base.Update(Entity);
        }
    }
}