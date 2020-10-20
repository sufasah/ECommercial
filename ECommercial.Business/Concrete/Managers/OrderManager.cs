using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers
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