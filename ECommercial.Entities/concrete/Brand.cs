using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string brand { get; set; }
    }
}