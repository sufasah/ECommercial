using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class TaxOfficeManager : EntityServiceBase<TaxOffice>,ITaxOfficeService
    {
        private ITaxOfficeDal _taxOfficeDal;
        private IEntityDal<TaxOffice> _entityDal;
        private IMapper _mapper;
        public TaxOfficeManager(ITaxOfficeDal taxOfficeDal,IEntityDal<TaxOffice> entityDal,IMapper mapper):base(taxOfficeDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _taxOfficeDal = taxOfficeDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override TaxOffice Add(TaxOffice Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(TaxOffice Entity)
        {
            base.Delete(Entity);
        }

        public override List<TaxOffice> GetAll()
        {
            return base.GetAll();
        }

        public override TaxOffice Update(TaxOffice Entity)
        {
            return base.Update(Entity);
        }
    }
}