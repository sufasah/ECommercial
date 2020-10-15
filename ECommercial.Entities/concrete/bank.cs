using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Bank:IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Web { get; set; }
        public virtual string Telex { get; set; }
        public virtual string Eft { get; set; }
        public virtual string Swift { get; set; }
    }
}