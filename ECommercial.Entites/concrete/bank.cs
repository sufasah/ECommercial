using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Bank:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string Telex { get; set; }
        public string Eft { get; set; }
        public string Swift { get; set; }
    }
}