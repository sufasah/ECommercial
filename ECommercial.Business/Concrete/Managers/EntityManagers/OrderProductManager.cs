using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class OrderProductManager : EntityServiceBase<OrderProduct>,IOrderProductService
    {
        private IOrderProductDal _orderProductDal;
        private IEntityDal<OrderProduct> _entityDal;
        private IMapper _mapper;
        public OrderProductManager(IOrderProductDal orderProductDal,IEntityDal<OrderProduct> entityDal,IMapper mapper):base(orderProductDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _orderProductDal = orderProductDal;
            _entityDal=entityDal;
            _mapper=mapper;
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