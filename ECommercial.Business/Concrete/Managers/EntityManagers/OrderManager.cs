using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderManager : EntityServiceBase<Order>,IOrderService
    {
        private IOrderDal _orderDal;
        private IEntityDal<Order> _entityDal;
        public OrderManager(IOrderDal orderDal,IEntityDal<Order> entityDal):base(orderDal,entityDal.GetPrimaryKeyMember())
        {
            _orderDal = orderDal;
            _entityDal=entityDal;
        }
        public override Order Add(Order Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Order Entity)
        {
            base.Delete(Entity);
        }

        public override List<Order> GetAll()
        {
            return base.GetAll();
        }

        public override Order Update(Order Entity)
        {
            return base.Update(Entity);
        }
    }
}