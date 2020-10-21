using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ShopProduct:IEntity
    {
        public ShopProduct()
        {
        }

        public ShopProduct(States state, int shopId, int productId, int variantGroupId, float productRating, int ratingCount, int stockAmount, DateTime releaseDatetime, int ıd, float price, short dayForCargo, string stockCode, string[] ımages)
        {
            State = state;
            ShopId = shopId;
            ProductId = productId;
            VariantGroupId = variantGroupId;
            ProductRating = productRating;
            RatingCount = ratingCount;
            StockAmount = stockAmount;
            ReleaseDatetime = releaseDatetime;
            Id = ıd;
            Price = price;
            DayForCargo = dayForCargo;
            StockCode = stockCode;
            Images = ımages;
        }

        public enum States{Onsale,Onstock};
        public virtual States? State { get; set; }
        public virtual int ShopId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int VariantGroupId { get; set; }
        public virtual float ProductRating { get; set; }
        public virtual int RatingCount { get; set; }
        public virtual int StockAmount { get; set; }
        public virtual DateTime ReleaseDatetime { get; set; }
        public virtual int Id { get; set; }
        public virtual float Price { get; set; }
        public virtual short DayForCargo { get; set; }
        public virtual string StockCode { get; set; }
        public virtual string[] Images { get; set; }
    }
}