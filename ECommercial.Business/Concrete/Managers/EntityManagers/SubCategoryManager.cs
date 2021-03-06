using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class SubCategoryManager : EntityServiceBase<SubCategory>,ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;
        private readonly IEntityDal<SubCategory> _entityDal;
        private readonly IMapper _mapper;
        public SubCategoryManager(ISubCategoryDal subCategoryDal,IEntityDal<SubCategory> entityDal,IMapper mapper):base(subCategoryDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _subCategoryDal = subCategoryDal;
            _entityDal=entityDal;
            _mapper=mapper;
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