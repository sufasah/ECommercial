using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class OrderProduct:IEntity
    {
        public enum OrderProductState{
            CanceledByShop,
            CanceledByUser,
            WaitingForPayment,
            OnReply,
            ReadyForShipping,
            OnCargoToUser,
            ConcludedSuccess,
            ConcludedDamaged,
            ConcludedReturn,
            ConcludedMissingPiece,
            ConcludedWrongPiece,
            ConcludedNotBeDelivered,
            SystemControl,
            OnCargoToShop
        };
        public OrderProduct()
        {
        }

        public OrderProduct(int? ıd, int? orderId, int? productId, int? count, OrderProductState? state)
        {
            Id = ıd;
            OrderId = orderId;
            ProductId = productId;
            Count = count;
            State = state;
        }

        public virtual int? Id { get; set; }
        public virtual long? OrderId { get; set; }
        public virtual int? ProductId { get; set; }
        public virtual int? Count { get; set; }
        public virtual OrderProductState? State { get; set; }
    }
}