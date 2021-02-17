using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderManager : EntityServiceBase<Order>,IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly IEntityDal<Order> _entityDal;
        private readonly IMapper _mapper;
        public OrderManager(IOrderDal orderDal,IEntityDal<Order> entityDal,IMapper mapper):base(orderDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _orderDal = orderDal;
            _entityDal=entityDal;
            _mapper=mapper;
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