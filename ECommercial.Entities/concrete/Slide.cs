using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class Slide:IEntity
    {
        public Slide()
        {
        }

        public Slide(int? ıd, short? slideOrder, string ımageUrl, string routeUrl)
        {
            Id = ıd;
            SlideOrder = slideOrder;
            ImageUrl = ımageUrl;
            RouteUrl = routeUrl;
        }

        public virtual int? Id { get; set; }
        public virtual short? SlideOrder { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string RouteUrl { get; set; }
    }
}