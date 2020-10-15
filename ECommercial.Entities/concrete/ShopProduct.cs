using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ShopProduct:IEntity
    {
        public enum States{Onsale,Onstock};
        public States State { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public int VariantGroupId { get; set; }
        public float ProductRating { get; set; }
        public int RatingCount { get; set; }
        public int StockAmount { get; set; }
        public DateTime ReleaseDatetime { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }
        public short DayForCargo { get; set; }
        public string StockCode { get; set; }
        public string[] Images { get; set; }
    }
}