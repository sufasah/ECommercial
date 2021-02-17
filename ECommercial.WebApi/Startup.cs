using System;
using AutoMapper;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Core.Utilities.Mappings;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.DataAccess.Concrete.EntityFramework;
using ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entities.concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
              options.UseNpgsql(Configuration.GetConnectionString("ECpgsql"),b => b.MigrationsAssembly("ECommercial.WebApi")));

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

            services.AddScoped( typeof(IProductService) , typeof(ProductManager));
            services.AddScoped( typeof(IProductDal) , typeof(EFProductDal));

            services.AddScoped( typeof(IAddressDal) , typeof(EFAddressDal));
            services.AddScoped( typeof(IAddressService) , typeof(AddressManager));
            
            services.AddScoped( typeof(IBankDal) , typeof(EFBankDal));
            services.AddScoped( typeof(IBankService) , typeof(BankManager));
            
            services.AddScoped( typeof(IBrandDal) , typeof(EFBrandDal));
            services.AddScoped( typeof(IBrandService) , typeof(BrandManager));
            
            services.AddScoped( typeof(ICampaignDal) , typeof(EFCampaignDal));
            services.AddScoped( typeof(ICampaignService) , typeof(CampaignManager));
            
            services.AddScoped( typeof(ICategoryDal) , typeof(EFCategoryDal));
            services.AddScoped( typeof(ICategoryService) , typeof(CategoryManager));
            
            services.AddScoped( typeof(ICityDal) , typeof(EFCityDal));
            services.AddScoped( typeof(ICityService) , typeof(CityManager));
            
            services.AddScoped( typeof(ICouponDal) , typeof(EFCouponDal));
            services.AddScoped( typeof(ICouponService) , typeof(CouponManager));
            
            services.AddScoped( typeof(IDistrictDal) , typeof(EFDistrictDal));
            services.AddScoped( typeof(IDistrictService) , typeof(DistrictManager));
            
            services.AddScoped( typeof(IFaqDal) , typeof(EFFaqDal));
            services.AddScoped( typeof(IFaqService) , typeof(FaqManager));
            
            services.AddScoped( typeof(IFaqCategoryDal) , typeof(EFFaqCategoryDal));
            services.AddScoped( typeof(IFaqCategoryService) , typeof(FaqCategoryManager));
            
            services.AddScoped( typeof(IFaqSubCategoryDal) , typeof(EFFaqSubCategoryDal));
            services.AddScoped( typeof(IFaqSubCategoryService) , typeof(FaqSubCategoryManager));
            
            services.AddScoped( typeof(IGeneralInfoDal) , typeof(EFGeneralInfoDal));
            services.AddScoped( typeof(IGeneralInfoService) , typeof(GeneralInfoManager));
            
            services.AddScoped( typeof(IInvoiceDal) , typeof(EFInvoiceDal));
            services.AddScoped( typeof(IInvoiceService) , typeof(InvoiceManager));
            
            services.AddScoped( typeof(IOrderDal) , typeof(EFOrderDal));
            services.AddScoped( typeof(IOrderService) , typeof(OrderManager));
            
            services.AddScoped( typeof(IOrderProductDal) , typeof(EFOrderProductDal));
            services.AddScoped( typeof(IOrderProductService) , typeof(OrderProductManager));
            
            services.AddScoped( typeof(IProductCampaignDal) , typeof(EFProductCampaignDal));
            services.AddScoped( typeof(IProductCampaignService) , typeof(ProductCampaignManager));
            
            services.AddScoped( typeof(IProductRateService) , typeof(ProductRateManager));
            services.AddScoped( typeof(IProductRateDal) , typeof(EFProductRateDal));
            
            services.AddScoped( typeof(IShopDal) , typeof(EFShopDal));
            services.AddScoped( typeof(IShopService) , typeof(ShopManager));
            
            services.AddScoped( typeof(IShopProductDal) , typeof(EFShopProductDal));
            services.AddScoped( typeof(IShopProductService) , typeof(ShopProductManager));
            
            services.AddScoped( typeof(ISlideDal) , typeof(EFSlideDal));
            services.AddScoped( typeof(ISlideService) , typeof(SlideManager));
            
            services.AddScoped( typeof(ISubCategoryDal) , typeof(EFSubCategoryDal));
            services.AddScoped( typeof(ISubCategoryService) , typeof(SubCategoryManager));
            
            services.AddScoped( typeof(ISubSubCategoryService) , typeof(SubSubCategoryManager));
            services.AddScoped( typeof(ISubSubCategoryDal) , typeof(EFSubSubCategoryDal));
            
            services.AddScoped( typeof(ITaxOfficeDal) , typeof(EFTaxOfficeDal));
            services.AddScoped( typeof(ITaxOfficeService) , typeof(TaxOfficeManager));
            
            services.AddScoped( typeof(IUserCouponDal) , typeof(EFUserCouponDal));
            services.AddScoped( typeof(IUserCouponService) , typeof(UserCouponManager));
            
            services.AddScoped( typeof(IUserFavouriteProductDal) , typeof(EFUserFavouriteProductDal));
            services.AddScoped( typeof(IUserFavouriteProductService) , typeof(UserFavouriteProductManager));
            
            services.AddScoped( typeof(IUserProductWillBeOrderedDal) , typeof(EFUserProductWillBeOrderedDal));
            services.AddScoped( typeof(IUserProductWillBeOrderedService) , typeof(UserProductWillBeOrderedManager));

            services.AddScoped( typeof(ILogDal) , typeof(EFLogDal));
            services.AddScoped( typeof(ILogService) , typeof(LogManager));

            services.AddScoped( typeof(IRoleDal) , typeof(EFRoleDal));
            services.AddScoped( typeof(IRoleService) , typeof(RoleManager));

            
            services.AddScoped( typeof(DbContext) , typeof(ECommercialContext));

            services.AddScoped( typeof(IEntityDal<>) , typeof(EFEntityDal<>));


        }
    }
}
