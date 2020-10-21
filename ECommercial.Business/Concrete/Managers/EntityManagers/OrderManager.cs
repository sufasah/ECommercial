using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderManager : EntityServiceBase<Order>,IOrderService
    {
        private IOrderDal _OrderDal;
        public OrderManager(IOrderDal OrderDal,MemberInfo EntityPrimaryKeyMember):base(OrderDal,EntityPrimaryKeyMember)
        {
            _OrderDal = OrderDal;
        }
    }
}