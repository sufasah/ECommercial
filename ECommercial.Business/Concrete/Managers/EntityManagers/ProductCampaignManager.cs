using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class ProductCampaignManager : EntityServiceBase<ProductCampaign>,IProductCampaignService
    {
        private IProductCampaignDal _productCampaignDal;
        private IEntityDal<ProductCampaign> _entityDal;
        private IMapper _mapper;
        public ProductCampaignManager(IProductCampaignDal productCampaignDal,IEntityDal<ProductCampaign> entityDal,IMapper mapper):base(productCampaignDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _productCampaignDal = productCampaignDal;
            _entityDal=entityDal;
            _mapper=mapper;
        }
        public override ProductCampaign Add(ProductCampaign Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(ProductCampaign Entity)
        {
            base.Delete(Entity);
        }

        public override List<ProductCampaign> GetAll()
        {
            return base.GetAll();
        }

        public override ProductCampaign Update(ProductCampaign Entity)
        {
            return base.Update(Entity);
        }
    }
}