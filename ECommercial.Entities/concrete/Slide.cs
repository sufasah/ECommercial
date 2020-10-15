using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Slide:IEntity
    {
        public int Id { get; set; }
        public short SlideOrder { get; set; }
        public string ImageUrl { get; set; }
        public string RouteUrl { get; set; }
    }
}