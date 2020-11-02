using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;
using ECommercial.Entites.concrete;
using FluentValidation;
using Ninject.Modules;

namespace ECommercial.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Address>>().To<AddressValidator>().InSingletonScope();
            Bind<IValidator<Bank>>().To<BankValidator>().InSingletonScope();
            Bind<IValidator<Brand>>().To<BrandValidator>().InSingletonScope();
            Bind<IValidator<Campaign>>().To<CampaignValidator>().InSingletonScope();
            Bind<IValidator<Category>>().To<CategoryValidator>().InSingletonScope();
            Bind<IValidator<City>>().To<CityValidator>().InSingletonScope();
            Bind<IValidator<Coupon>>().To<CouponValidator>().InSingletonScope();
            Bind<IValidator<District>>().To<DistrictValidator>().InSingletonScope();
            Bind<IValidator<Faq>>().To<FaqValidator>().InSingletonScope();
            Bind<IValidator<FaqCategory>>().To<FaqCategoryValidator>().InSingletonScope();
            Bind<IValidator<FaqSubCategory>>().To<FaqSubCategoryValidator>().InSingletonScope();
            Bind<IValidator<GeneralInfo>>().To<GeneralInfoValidator>().InSingletonScope();
            Bind<IValidator<Invoice>>().To<InvoiceValidator>().InSingletonScope();
            Bind<IValidator<Order>>().To<OrderValidator>().InSingletonScope();
            Bind<IValidator<OrderProduct>>().To<OrderProductValidator>().InSingletonScope();
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
            Bind<IValidator<ProductCampaign>>().To<ProductCampaignValidator>().InSingletonScope();
            Bind<IValidator<ProductRate>>().To<ProductRateValidator>().InSingletonScope();
            Bind<IValidator<Shop>>().To<ShopValidator>().InSingletonScope();
            Bind<IValidator<ShopProduct>>().To<ShopProductValidator>().InSingletonScope();
            Bind<IValidator<Slide>>().To<SlideValidator>().InSingletonScope();
            Bind<IValidator<SubCategory>>().To<SubCategoryValidator>().InSingletonScope();
            Bind<IValidator<SubSubCategory>>().To<SubSubCategoryValidator>().InSingletonScope();
            Bind<IValidator<TaxOffice>>().To<TaxOfficeValidator>().InSingletonScope();
            Bind<IValidator<User>>().To<UserValidator>().InSingletonScope();
            Bind<IValidator<UserCoupon>>().To<UserCouponValidator>().InSingletonScope();
            Bind<IValidator<UserFavouriteProduct>>().To<UserFavouriteProductValidator>().InSingletonScope();
            Bind<IValidator<UserProductWillBeOrdered>>().To<UserProductWillBeOrderedValidator>().InSingletonScope();
            Bind<IValidator<Role>>().To<RoleValidator>().InSingletonScope();
            Bind<IValidator<UserRole>>().To<UserRoleValidator>().InSingletonScope();
            Bind<IValidator<Log>>().To<LogValidator>().InSingletonScope();
            
        }
    }
}