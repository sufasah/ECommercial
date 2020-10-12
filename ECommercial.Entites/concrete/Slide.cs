using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Slide:IEntity
    {
        public int Id { get; set; }
        public Int16 SlideOrder { get; set; }
        public string ImageUrl { get; set; }
        public string RouteUrl { get; set; }
    }
}