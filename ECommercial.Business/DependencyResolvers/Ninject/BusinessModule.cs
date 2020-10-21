using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Core.DataAccess;
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals;
using ECommercial.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;

namespace ECommercial.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EFProductDal>();

            Bind<IAddressDal>().To<EFAddressDal>();
            Bind<IAddressService>().To<AddressManager>();
            
            Bind<IBankDal>().To<EFBankDal>();
            Bind<IBankService>().To<BankManager>();
            
            Bind<IBrandDal>().To<EFBrandDal>();
            Bind<IBrandService>().To<BrandManager>();
            
            Bind<ICampaignDal>().To<EFCampaignDal>();
            Bind<ICampaignService>().To<CampaignManager>();
            
            Bind<ICategoryDal>().To<EFCategoryDal>();
            Bind<ICategoryService>().To<CategoryManager>();
            
            Bind<ICityDal>().To<EFCityDal>();
            Bind<ICityService>().To<CityManager>();
            
            Bind<ICouponDal>().To<EFCouponDal>();
            Bind<ICouponService>().To<CouponManager>();
            
            Bind<IDistrictDal>().To<EFDistrictDal>();
            Bind<IDistrictService>().To<DistrictManager>();
            
            Bind<IFaqCategoryDal>().To<EFFaqCategoryDal>();
            Bind<IFaqCategoryService>().To<FaqCategoryManager>();
            
            Bind<IFaqSubCategoryDal>().To<EFFaqSubCategoryDal>();
            Bind<IFaqSubCategoryService>().To<FaqSubCategoryManager>();
            
            Bind<IGeneralInfoDal>().To<EFGeneralInfoDal>();
            Bind<IGeneralInfoService>().To<GeneralInfoManager>();
            
            Bind<IInvoiceDal>().To<EFInvoiceDal>();
            Bind<IInvoiceService>().To<InvoiceManager>();
            
            Bind<IOrderDal>().To<EFOrderDal>();
            Bind<IOrderService>().To<OrderManager>();
            
            Bind<IOrderProductDal>().To<EFOrderProductDal>();
            Bind<IOrderProductService>().To<OrderProductManager>();
            
            Bind<IProductCampaignDal>().To<EFProductCampaignDal>();
            Bind<IProductCampaignService>().To<ProductCampaignManager>();
            
            Bind<IProductRateService>().To<ProductRateManager>();
            Bind<IProductRateDal>().To<EFProductRateDal>();
            
            Bind<IShopDal>().To<EFShopDal>();
            Bind<IShopService>().To<ShopManager>();
            
            Bind<IShopProductDal>().To<EFShopProductDal>();
            Bind<IShopProductService>().To<ShopProductManager>();
            
            Bind<ISlideDal>().To<EFSlideDal>();
            Bind<ISlideService>().To<SlideManager>();
            
            Bind<ISubCategoryDal>().To<EFSubCategoryDal>();
            Bind<ISubCategoryService>().To<SubCategoryManager>();
            
            Bind<ISubSubCategoryService>().To<SubSubCategoryManager>();
            Bind<ISubSubCategoryDal>().To<EFSubSubCategoryDal>();
            
            Bind<ITaxOfficeDal>().To<EFTaxOfficeDal>();
            Bind<ITaxOfficeService>().To<TaxOfficeManager>();
            
            Bind<IUserCouponDal>().To<EFUserCouponDal>();
            Bind<IUserCouponService>().To<UserCouponManager>();
            
            Bind<IUserDal>().To<EFUserDal>();
            Bind<IUserService>().To<UserManager>();
                        
            Bind<IUserFavouriteProductDal>().To<EFUserFavouriteProductDal>();
            Bind<IUserFavouriteProductService>().To<UserFavouriteProductManager>();
            
            Bind<IUserProductWillBeOrderedDal>().To<EFUserProductWillBeOrdered>();
            Bind<IUserProductWillBeOrderedService>().To<UserProductWillBeOrderedManager>();
            
            Bind<DbContext>().To<ECommercialContext>();

        }
    }
}