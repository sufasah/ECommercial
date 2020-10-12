using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class GeneralInfo:IEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}