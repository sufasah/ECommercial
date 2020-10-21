using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderProductManager : EntityServiceBase<OrderProduct>,IOrderProductService
    {
        private IOrderProductDal _OrderProductDal;
        public OrderProductManager(IOrderProductDal OrderProductDal,MemberInfo EntityPrimaryKeyMember):base(OrderProductDal,EntityPrimaryKeyMember)
        {
            _OrderProductDal = OrderProductDal;
        }
    }
}