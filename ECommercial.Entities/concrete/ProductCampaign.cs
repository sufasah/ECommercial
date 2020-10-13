using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductCampaign:IEntity
    {
        public int Id { get; set; }
        public int ProductId{ get; set;}
        public int CampaignId { get; set; }
    }
}