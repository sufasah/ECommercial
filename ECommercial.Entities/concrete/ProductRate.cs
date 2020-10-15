using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductRate:IEntity
    {
        public DateTime Datetime { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool HidUserInfoEnabled { get; set; }
        public int Id { get; set; }
        public short Rate { get; set; }
        public string Comment { get; set; }
        public string[] Images { get; set; }
    }
}