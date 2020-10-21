using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderProductManager : EntityServiceBase<OrderProduct>,IOrderProductService
    {
        private IOrderProductDal _orderProductDal;
        public OrderProductManager(IOrderProductDal OrderProductDal,MemberInfo EntityPrimaryKeyMember):base(OrderProductDal,EntityPrimaryKeyMember)
        {
            _orderProductDal = OrderProductDal;
        }
        public override OrderProduct Add(OrderProduct Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(OrderProduct Entity)
        {
            base.Delete(Entity);
        }

        public override List<OrderProduct> GetAll()
        {
            return base.GetAll();
        }

        public override OrderProduct Update(OrderProduct Entity)
        {
            return base.Update(Entity);
        }
    }
}