using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class ProductCampaign:IEntity
    {
        public ProductCampaign()
        {
        }

        public ProductCampaign(int ıd, int productId, int campaignId)
        {
            Id = ıd;
            ProductId = productId;
            CampaignId = campaignId;
        }

        public virtual int Id { get; set; }
        public virtual int ProductId{ get; set;}
        public virtual int CampaignId { get; set; }
    }
}