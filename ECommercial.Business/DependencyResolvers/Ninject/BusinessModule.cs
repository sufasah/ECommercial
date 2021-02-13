using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.Concrete.EntityFramework;
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
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EFProductDal>().InSingletonScope();

            Bind<IAddressDal>().To<EFAddressDal>().InSingletonScope();
            Bind<IAddressService>().To<AddressManager>().InSingletonScope();
            
            Bind<IBankDal>().To<EFBankDal>().InSingletonScope();
            Bind<IBankService>().To<BankManager>().InSingletonScope();
            
            Bind<IBrandDal>().To<EFBrandDal>().InSingletonScope();
            Bind<IBrandService>().To<BrandManager>().InSingletonScope();
            
            Bind<ICampaignDal>().To<EFCampaignDal>().InSingletonScope();
            Bind<ICampaignService>().To<CampaignManager>().InSingletonScope();
            
            Bind<ICategoryDal>().To<EFCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            
            Bind<ICityDal>().To<EFCityDal>().InSingletonScope();
            Bind<ICityService>().To<CityManager>().InSingletonScope();
            
            Bind<ICouponDal>().To<EFCouponDal>().InSingletonScope();
            Bind<ICouponService>().To<CouponManager>().InSingletonScope();
            
            Bind<IDistrictDal>().To<EFDistrictDal>().InSingletonScope();
            Bind<IDistrictService>().To<DistrictManager>().InSingletonScope();
            
            Bind<IFaqDal>().To<EFFaqDal>().InSingletonScope();
            Bind<IFaqService>().To<FaqManager>().InSingletonScope();
            
            Bind<IFaqCategoryDal>().To<EFFaqCategoryDal>().InSingletonScope();
            Bind<IFaqCategoryService>().To<FaqCategoryManager>().InSingletonScope();
            
            Bind<IFaqSubCategoryDal>().To<EFFaqSubCategoryDal>().InSingletonScope();
            Bind<IFaqSubCategoryService>().To<FaqSubCategoryManager>().InSingletonScope();
            
            Bind<IGeneralInfoDal>().To<EFGeneralInfoDal>().InSingletonScope();
            Bind<IGeneralInfoService>().To<GeneralInfoManager>().InSingletonScope();
            
            Bind<IInvoiceDal>().To<EFInvoiceDal>().InSingletonScope();
            Bind<IInvoiceService>().To<InvoiceManager>().InSingletonScope();
            
            Bind<IOrderDal>().To<EFOrderDal>().InSingletonScope();
            Bind<IOrderService>().To<OrderManager>().InSingletonScope();
            
            Bind<IOrderProductDal>().To<EFOrderProductDal>().InSingletonScope();
            Bind<IOrderProductService>().To<OrderProductManager>().InSingletonScope();
            
            Bind<IProductCampaignDal>().To<EFProductCampaignDal>().InSingletonScope();
            Bind<IProductCampaignService>().To<ProductCampaignManager>().InSingletonScope();
            
            Bind<IProductRateService>().To<ProductRateManager>().InSingletonScope();
            Bind<IProductRateDal>().To<EFProductRateDal>().InSingletonScope();
            
            Bind<IShopDal>().To<EFShopDal>().InSingletonScope();
            Bind<IShopService>().To<ShopManager>().InSingletonScope();
            
            Bind<IShopProductDal>().To<EFShopProductDal>().InSingletonScope();
            Bind<IShopProductService>().To<ShopProductManager>().InSingletonScope();
            
            Bind<ISlideDal>().To<EFSlideDal>().InSingletonScope();
            Bind<ISlideService>().To<SlideManager>().InSingletonScope();
            
            Bind<ISubCategoryDal>().To<EFSubCategoryDal>().InSingletonScope();
            Bind<ISubCategoryService>().To<SubCategoryManager>().InSingletonScope();
            
            Bind<ISubSubCategoryService>().To<SubSubCategoryManager>().InSingletonScope();
            Bind<ISubSubCategoryDal>().To<EFSubSubCategoryDal>().InSingletonScope();
            
            Bind<ITaxOfficeDal>().To<EFTaxOfficeDal>().InSingletonScope();
            Bind<ITaxOfficeService>().To<TaxOfficeManager>().InSingletonScope();
            
            Bind<IUserCouponDal>().To<EFUserCouponDal>().InSingletonScope();
            Bind<IUserCouponService>().To<UserCouponManager>().InSingletonScope();
            
                        
            Bind<IUserFavouriteProductDal>().To<EFUserFavouriteProductDal>().InSingletonScope();
            Bind<IUserFavouriteProductService>().To<UserFavouriteProductManager>().InSingletonScope();
            
            Bind<IUserProductWillBeOrderedDal>().To<EFUserProductWillBeOrderedDal>().InSingletonScope();
            Bind<IUserProductWillBeOrderedService>().To<UserProductWillBeOrderedManager>().InSingletonScope();

            Bind<ILogDal>().To<EFLogDal>().InSingletonScope();
            Bind<ILogService>().To<LogManager>().InSingletonScope();

            Bind<IRoleDal>().To<EFRoleDal>().InSingletonScope();
            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            
            Bind<DbContext>().To<ECommercialContext>().InSingletonScope();

            Bind(typeof(IEntityDal<>)).To(typeof(EFEntityDal<>)).InSingletonScope();

        }
    }
}