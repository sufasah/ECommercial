using System;
using System.Collections.Generic;
using ECommercial.Entites.concrete;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;
using System.Linq;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation
{
    public class EntityValidationFixture : IDisposable
    {
        
        public static List<Object[]> Entities = EntityValidationFixture.InitializeEntities();

        public static List<Object[]> Validators = EntityValidationFixture.InitializeValidators();
        public static List<Object[]> EntityValidator= EntityValidationFixture.InitializeEntityValidator();
        public EntityValidationFixture()
        {

        }

        public void Dispose()
        {
            
        }

        
        public static List<Object[]> InitializeEntities(){
            
            
            return new List<Object[]>(){
                new Object[]{ new Address((short)idExample,(short)idExample,phoneExample,(short)idExample,addressExample,nameExample,surnameExample)},
                new Object[]{ new Bank((short)idExample,bankNameExample,addressExample,telephoneExample,faxExample,websiteExample,telexExample,eftExample,swiftExample)},
                new Object[]{ new Brand((int)idExample,brandExample)},
                new Object[]{ new Campaign((int)idExample,startDateExample,endDateExample,rateExample)},
                new Object[]{ new Category((short)idExample,titleExample)},
                new Object[]{ new City((short)idExample,cityNameExample)},
                new Object[]{ new Coupon((int)idExample,500)},
                new Object[]{ new District((short)idExample,(short)idExample,cityNameExample)},
                new Object[]{ new Faq((short)idExample,(short)idExample,titleExample,contentExample)},
                new Object[]{ new FaqCategory((short)idExample,titleExample)},
                new Object[]{ new FaqSubCategory((short)idExample,(short)idExample,titleExample)},
                new Object[]{ new GeneralInfo(stringKeyExample,titleExample)},
                new Object[]{ new Invoice(Invoice.Types.individual,(int)idExample,phoneExample,(short)idExample,(int)idExample,nameExample,nameExample,surnameExample,addressExample)},
                new Object[]{ new Order(idExample,(int)idExample,(int)idExample,(int)idExample,endDateExample)},
                new Object[]{ new OrderProduct((int)idExample,(int)idExample,(int)idExample,21,OrderProduct.OrderProductState.OnReply)},
                new Object[]{ new Product(45,125125125,(short)idExample,(int)idExample,rateExample,42,Product.WarrantyTypes.Day,(int)idExample,rateExample,421,nameExample,stringArrayExample,stringKeyExample,contentExample)},
                new Object[]{ new ProductCampaign((int)idExample,(int)idExample,(int)idExample)},
                new Object[]{ new ProductRate(endDateExample,(int)idExample,(int)idExample,boolExample,(int)idExample,3,contentExample,stringArrayExample)},
                
                new Object[]{ new Shop(ibanExample,phoneExample,phoneExample,Shop.FirmTypes.Incorporated,Shop.FirmProfiles.Importer,(short)idExample,123123
                ,(short)idExample,(short)idExample,22222222222,1234567890123456,phoneExample,(short)idExample,(short)idExample,(short)idExample
                ,1523,1234567890123456,(int)idExample,boolExample,usernameExample,passwordExample,nameExample,nameExample,surnameExample
                ,addressExample,"IT Manager",nameExample,emailExample,nameExample,surnameExample,bankNameExample,kepMailExample,websiteExample,
                emailExample,"For Example ltd. şti.",emailExample)},
                
                new Object[]{ new ShopProduct(ShopProduct.States.Onsale,(int)idExample,(int)idExample,21,rateExample,125,32,endDateExample,(int)idExample,124.42f,12,"dEF12-k3",new string[]{urlExample})},
                new Object[]{ new Slide((int)idExample,2,urlExample,websiteExample)},
                new Object[]{ new SubCategory((short)idExample,(short)idExample,titleExample)},
                new Object[]{ new SubSubCategory((short)idExample,(short)idExample,titleExample)},
                new Object[]{ new TaxOffice((short)idExample,(short)idExample,(short)idExample,1250,"Nazilli Vergi Dairesi Müdürlüğü")},
                new Object[]{ new User(boolExample,boolExample,boolExample,(int)idExample,phoneExample,endDateExample,emailExample,nameExample,surnameExample)},
                new Object[]{ new UserCoupon((int)idExample,(int)idExample,(int)idExample)},
                new Object[]{ new UserFavouriteProduct((int)idExample,(int)idExample,(int)idExample)},
                new Object[]{ new UserProductWillBeOrdered((int)idExample,(int)idExample,(int)idExample)}
            };
        }

        public static List<Object[]> InitializeValidators(){
            
            return new List<Object[]>(){
                new Object[]{ new AddressValidator()},
                new Object[]{ new BankValidator()},
                new Object[]{ new BrandValidator()},
                new Object[]{ new CampaignValidator()},
                new Object[]{ new CategoryValidator()},
                new Object[]{ new CityValidator()},
                new Object[]{ new CouponValidator()},
                new Object[]{ new DistrictValidator()},
                new Object[]{ new FaqValidator()},
                new Object[]{ new FaqCategoryValidator()},
                new Object[]{ new FaqSubCategoryValidator()},
                new Object[]{ new GeneralInfoValidator()},
                new Object[]{ new InvoiceValidator()},
                new Object[]{ new OrderValidator()},
                new Object[]{ new OrderProductValidator()},
                new Object[]{ new ProductValidator()},
                new Object[]{ new ProductCampaignValidator()},
                new Object[]{ new ProductRateValidator()},
                new Object[]{ new ShopValidator()},
                new Object[]{ new ShopProductValidator()},
                new Object[]{ new SlideValidator()},
                new Object[]{ new SubCategoryValidator()},
                new Object[]{ new SubSubCategoryValidator()},
                new Object[]{ new TaxOfficeValidator()},
                new Object[]{ new UserValidator()},
                new Object[]{ new UserCouponValidator()},
                new Object[]{ new UserFavouriteProductValidator()},
                new Object[]{ new UserProductWillBeOrderedValidator()}
            };
        }
        
        public static List<Object[]> InitializeEntityValidator(){
            return Validators.Select((val,index)=>new Object[]{Validators[index][0],Entities[index][0]}).ToList();
        }

        public static string addressExample="Büyükdere Cad. Rumelihan No 40 Kat 2 Mecidiyeköy İstanbul";
        public static long phoneExample=5444444444L;
        public static string nameExample="Ahmet";
        public static string surnameExample="Günay";
        public static long idExample=54L;
        public static string telephoneExample="212-2726446";
        public static string faxExample="212-2726446";
        public static string websiteExample="www.google.com";
        public static string telexExample="27282 adb TR";
        public static string eftExample="0100";
        public static string swiftExample="ADABTRIS";
        public static string bankNameExample="ZiraatBank A.Ş.";
        public static string brandExample="Vestel";
        public static DateTime startDateExample=DateTime.Now.AddDays(-5.0);
        public static DateTime endDateExample=DateTime.Now;
        public static float rateExample=72.52f;
        public static string titleExample="Kitchen Staff";
        public static string cityNameExample="İstanbul";
        public static string contentExample="This is a really loooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong content.";
        public static string stringKeyExample="AnExampleKey";
        public static string[] stringArrayExample=new string[]{"test:value"};
        public static bool boolExample=true;
        public static string ibanExample="TR3550000000054910000003";
        public static string usernameExample="username_example03";
        public static string passwordExample="myPassword";
        public static string emailExample="test@hotmail.com";
        public static string kepMailExample="test@kep.tr";
        public static string urlExample = "./test/url/example/here.txt";
    }
}
