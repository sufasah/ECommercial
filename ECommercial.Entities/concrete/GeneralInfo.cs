using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class GeneralInfo:IEntity
    {
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}