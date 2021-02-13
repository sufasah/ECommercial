using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class GeneralInfo:IEntity
    {
        public GeneralInfo()
        {
        }

        public GeneralInfo(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}