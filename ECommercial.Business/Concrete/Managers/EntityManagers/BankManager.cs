using System.Collections.Generic;
using AutoMapper;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class BankManager : EntityServiceBase<Bank>,IBankService
    {
        private IBankDal _bankDal;
        private IEntityDal<Bank> _entityDal;
        private IMapper _mapper;
        public BankManager(IBankDal bankDal,IEntityDal<Bank> entityDal,IMapper mapper):base(bankDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _bankDal = bankDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override Bank Add(Bank Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Bank Entity)
        {
            base.Delete(Entity);
        }

        public override List<Bank> GetAll()
        {
            return base.GetAll();
        }

        public override Bank Update(Bank Entity)
        {
            return base.Update(Entity);
        }
    }
}