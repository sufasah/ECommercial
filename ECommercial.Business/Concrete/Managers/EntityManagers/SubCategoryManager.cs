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
        private IEntityDal<SubCategory> _entityDal;
        public SubCategoryManager(ISubCategoryDal subCategoryDal,IEntityDal<SubCategory> entityDal):base(subCategoryDal,entityDal.GetPrimaryKeyMember())
        {
            _subCategoryDal = subCategoryDal;
            _entityDal=entityDal;
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