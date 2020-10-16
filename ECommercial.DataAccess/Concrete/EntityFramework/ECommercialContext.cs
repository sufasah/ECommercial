using ECommercial.Core.DataAccess.EntitiyFramework.Mappings;
using ECommercial.Entites.concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.DataAccess.EntityFramework
{
    public class ECommercialContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new BankMap());
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new CampaignMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new CouponMap());
            modelBuilder.ApplyConfiguration(new DistrictMap());
            modelBuilder.ApplyConfiguration(new FaqCategoryMap());
            modelBuilder.ApplyConfiguration(new FaqMap());
            modelBuilder.ApplyConfiguration(new FaqSubcategoryMap());
            modelBuilder.ApplyConfiguration(new GeneralInfoMap());
            modelBuilder.ApplyConfiguration(new InvoiceMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderProductMap());
            modelBuilder.ApplyConfiguration(new ProductCampaignMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductRateMap());
            modelBuilder.ApplyConfiguration(new ShopMap());
            modelBuilder.ApplyConfiguration(new ShopProductMap());
            modelBuilder.ApplyConfiguration(new SlideMap());
            modelBuilder.ApplyConfiguration(new SubCategoryMap());
            modelBuilder.ApplyConfiguration(new SubSubCategoryMap());
            modelBuilder.ApplyConfiguration(new TaxOfficeMap());
            modelBuilder.ApplyConfiguration(new UserCouponMap());
            modelBuilder.ApplyConfiguration(new UserFavouriteProductMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserProductWillBeOrderedMap());
            

            
        }
        public DbSet<Address> Addresses {get;set;}
        public DbSet<Bank> Banks {get;set;}
        public DbSet<Brand> Brands {get;set;}
        public DbSet<Campaign> Campaigns {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<City> Cities {get;set;}
        public DbSet<Coupon> Coupons {get;set;}
        public DbSet<District> Districts {get;set;}
        public DbSet<Faq> Faqs {get;set;}
        public DbSet<FaqCategory> FaqCategories {get;set;}
        public DbSet<FaqSubCategory> FaqSubCategories {get;set;}
        public DbSet<GeneralInfo> GeneralInfos {get;set;}
        public DbSet<Invoice> Invoices {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<OrderProduct> OrderProducts {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<ProductCampaign> ProductCampaigns {get;set;}
        public DbSet<ProductRate> ProductRates {get;set;}
        public DbSet<Shop> Shops {get;set;}
        public DbSet<ShopProduct> ShopProducts {get;set;}
        public DbSet<Slide> Slides {get;set;}
        public DbSet<SubCategory> SubCategories {get;set;}
        public DbSet<SubSubCategory> SubSubCategories {get;set;}
        public DbSet<TaxOffice> TaxOffices {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<UserCoupon> UserCoupons {get;set;}
        public DbSet<UserFavouriteProduct> UserFavouriteProducts {get;set;}
        public DbSet<UserProductWillBeOrdered> UserProductsWillBeOrdered {get;set;}        
    }
}