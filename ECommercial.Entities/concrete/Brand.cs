using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Brand:IEntity
    {
        
        public Brand()
        {
        }

        public Brand(int ıd, string brand)
        {
            Id = ıd;
            this.brand = brand;
        }

        public virtual int? Id { get; set; }
        public virtual string brand { get; set; }
    }
}