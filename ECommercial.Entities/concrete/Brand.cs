using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Brand:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string brand { get; set; }
    }
}