using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductCampaign:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int ProductId{ get; set;}
        public virtual int CampaignId { get; set; }
    }
}