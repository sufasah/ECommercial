using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
{
    public class BankManager : EntityServiceBase<Bank>,IBankService
    {
        private IBankDal _BankDal;
        public BankManager(IBankDal BankDal,MemberInfo EntityPrimaryKeyMember):base(BankDal,EntityPrimaryKeyMember)
        {
            _BankDal = BankDal;
        }
    }
}