using System;
using AutoMapper;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Core.Utilities.Mappings;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.Concrete.EntityFramework;
using ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entites.concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ECommercial.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
                
            services.AddControllersWithViews();
            
            services.AddRazorPages();

            ManagerDependencies(services);
            
            services.AddSingleton<IMapper>(AutoMapperHelper.CreateConfiguration().CreateMapper());

            services.AddDbContext<ECommercialContext>(options => 
              options.UseNpgsql(Configuration.GetConnectionString("ECpgsql")));

            services.AddDefaultIdentity<ECUser>()
            .AddEntityFrameworkStores<ECommercialContext>()
            .AddDefaultTokenProviders();
            
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else{
                app.UseExceptionHandler("Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }
            app.UseRouting();
            
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });

        }
        
        private void ManagerDependencies(IServiceCollection services){

            services.AddSingleton( typeof(IProductService) , typeof(ProductManager));
            services.AddSingleton( typeof(IProductDal) , typeof(EFProductDal));

            services.AddSingleton( typeof(IAddressDal) , typeof(EFAddressDal));
            services.AddSingleton( typeof(IAddressService) , typeof(AddressManager));
            
            services.AddSingleton( typeof(IBankDal) , typeof(EFBankDal));
            services.AddSingleton( typeof(IBankService) , typeof(BankManager));
            
            services.AddSingleton( typeof(IBrandDal) , typeof(EFBrandDal));
            services.AddSingleton( typeof(IBrandService) , typeof(BrandManager));
            
            services.AddSingleton( typeof(ICampaignDal) , typeof(EFCampaignDal));
            services.AddSingleton( typeof(ICampaignService) , typeof(CampaignManager));
            
            services.AddSingleton( typeof(ICategoryDal) , typeof(EFCategoryDal));
            services.AddSingleton( typeof(ICategoryService) , typeof(CategoryManager));
            
            services.AddSingleton( typeof(ICityDal) , typeof(EFCityDal));
            services.AddSingleton( typeof(ICityService) , typeof(CityManager));
            
            services.AddSingleton( typeof(ICouponDal) , typeof(EFCouponDal));
            services.AddSingleton( typeof(ICouponService) , typeof(CouponManager));
            
            services.AddSingleton( typeof(IDistrictDal) , typeof(EFDistrictDal));
            services.AddSingleton( typeof(IDistrictService) , typeof(DistrictManager));
            
            services.AddSingleton( typeof(IFaqDal) , typeof(EFFaqDal));
            services.AddSingleton( typeof(IFaqService) , typeof(FaqManager));
            
            services.AddSingleton( typeof(IFaqCategoryDal) , typeof(EFFaqCategoryDal));
            services.AddSingleton( typeof(IFaqCategoryService) , typeof(FaqCategoryManager));
            
            services.AddSingleton( typeof(IFaqSubCategoryDal) , typeof(EFFaqSubCategoryDal));
            services.AddSingleton( typeof(IFaqSubCategoryService) , typeof(FaqSubCategoryManager));
            
            services.AddSingleton( typeof(IGeneralInfoDal) , typeof(EFGeneralInfoDal));
            services.AddSingleton( typeof(IGeneralInfoService) , typeof(GeneralInfoManager));
            
            services.AddSingleton( typeof(IInvoiceDal) , typeof(EFInvoiceDal));
            services.AddSingleton( typeof(IInvoiceService) , typeof(InvoiceManager));
            
            services.AddSingleton( typeof(IOrderDal) , typeof(EFOrderDal));
            services.AddSingleton( typeof(IOrderService) , typeof(OrderManager));
            
            services.AddSingleton( typeof(IOrderProductDal) , typeof(EFOrderProductDal));
            services.AddSingleton( typeof(IOrderProductService) , typeof(OrderProductManager));
            
            services.AddSingleton( typeof(IProductCampaignDal) , typeof(EFProductCampaignDal));
            services.AddSingleton( typeof(IProductCampaignService) , typeof(ProductCampaignManager));
            
            services.AddSingleton( typeof(IProductRateService) , typeof(ProductRateManager));
            services.AddSingleton( typeof(IProductRateDal) , typeof(EFProductRateDal));
            
            services.AddSingleton( typeof(IShopDal) , typeof(EFShopDal));
            services.AddSingleton( typeof(IShopService) , typeof(ShopManager));
            
            services.AddSingleton( typeof(IShopProductDal) , typeof(EFShopProductDal));
            services.AddSingleton( typeof(IShopProductService) , typeof(ShopProductManager));
            
            services.AddSingleton( typeof(ISlideDal) , typeof(EFSlideDal));
            services.AddSingleton( typeof(ISlideService) , typeof(SlideManager));
            
            services.AddSingleton( typeof(ISubCategoryDal) , typeof(EFSubCategoryDal));
            services.AddSingleton( typeof(ISubCategoryService) , typeof(SubCategoryManager));
            
            services.AddSingleton( typeof(ISubSubCategoryService) , typeof(SubSubCategoryManager));
            services.AddSingleton( typeof(ISubSubCategoryDal) , typeof(EFSubSubCategoryDal));
            
            services.AddSingleton( typeof(ITaxOfficeDal) , typeof(EFTaxOfficeDal));
            services.AddSingleton( typeof(ITaxOfficeService) , typeof(TaxOfficeManager));
            
            services.AddSingleton( typeof(IUserCouponDal) , typeof(EFUserCouponDal));
            services.AddSingleton( typeof(IUserCouponService) , typeof(UserCouponManager));
            
            services.AddSingleton( typeof(IUserFavouriteProductDal) , typeof(EFUserFavouriteProductDal));
            services.AddSingleton( typeof(IUserFavouriteProductService) , typeof(UserFavouriteProductManager));
            
            services.AddSingleton( typeof(IUserProductWillBeOrderedDal) , typeof(EFUserProductWillBeOrderedDal));
            services.AddSingleton( typeof(IUserProductWillBeOrderedService) , typeof(UserProductWillBeOrderedManager));

            services.AddSingleton( typeof(ILogDal) , typeof(EFLogDal));
            services.AddSingleton( typeof(ILogService) , typeof(LogManager));

            services.AddSingleton( typeof(IRoleDal) , typeof(EFRoleDal));
            services.AddSingleton( typeof(IRoleService) , typeof(RoleManager));

            
            services.AddSingleton( typeof(DbContext) , typeof(ECommercialContext));

            services.AddSingleton( typeof(IEntityDal<>) , typeof(EFEntityDal<>));


        }
    }
}
