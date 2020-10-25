using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductRate:IEntity
    {
        public ProductRate()
        {
        }

        public ProductRate(DateTime? datetime, int? productId, int? userId, bool? hidUserInfoEnabled, int? ıd, short? rate, string? comment, string[] ımages)
        {
            Datetime = datetime;
            ProductId = productId;
            UserId = userId;
            HidUserInfoEnabled = hidUserInfoEnabled;
            Id = ıd;
            Rate = rate;
            Comment = comment;
            Images = ımages;
        }

        public virtual DateTime? Datetime { get; set; }
        public virtual int? ProductId { get; set; }
        public virtual int? UserId { get; set; }
        public virtual bool? HidUserInfoEnabled { get; set; }
        public virtual int? Id { get; set; }
        public virtual short? Rate { get; set; }
        public virtual string Comment { get; set; }
        public virtual string[] Images { get; set; }
    }
}