using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class Log:IEntity
    {
        public Log()
        {
            
        }
        public Log(int? ıd, string detail, DateTime? date, string audit)
        {
            Id = ıd;
            Detail = detail;
            Date = date;
            Audit = audit;
        }

        public virtual int? Id { get; set; }
        public virtual string Detail{ get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual string Audit { get; set; }
    }
}