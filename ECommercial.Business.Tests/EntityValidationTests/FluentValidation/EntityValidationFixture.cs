using System;
using System.Collections.Generic;
using ECommercial.Core.Entities;
using ECommercial.Entites.concrete;
using FluentValidation;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation
{
    public class EntityValidationFixture : IDisposable
    {
        
        public List<IEntity> Entities;
        public List<IValidator> Validators;
        public EntityValidationFixture()
        {
            initializeEntities();
            initializeValidators();
        }

        public void initializeEntities(){
            var addressExample="Büyükdere Cad. Rumelihan No 40 Kat 2 Mecidiyeköy İstanbul";
            var phoneExample=5444444444L;
            var nameExample="Ahmet";
            var surnameExample="Günay";
            var idExample=54L;
            var telephoneExample="212-2726446";
            var faxExample="212-2726446";
            var websiteExample="www.google.com";
            var telexExample="27282 adb TR";
            var eftExample="0100";
            var swiftExample="ADABTRIS";
            var bankNameExample="ZiraatBank A.Ş.";
            var brandExample="Vestel";
            var startDateExample=new DateTime().AddDays(-5);
            var endDateExample=new DateTime();
            var rateExample=72.52f;
            var titleExample="Kitchen Staff";
            var cityNameExample="İstanbul";
            var contentExample="This is a really loooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong content.";
            var stringKeyExample="AnExampleKey";
            var stringArrayExample=new string[]{"test:value"};
            var boolExample=true;
            var ibanExample="TR3550000000054910000003";
            var usernameExample="username_example03";
            var passwordExample="myPassword";
            var emailExample="test@hotmail.com";
            var kepMailExample="test@kep.tr";
            var urlExample = "./test/url/example/here.txt";
            Entities = new List<IEntity>(){
                new Address((short)idExample,(short)idExample,phoneExample,(short)idExample,addressExample,nameExample,surnameExample),
                new Bank((short)idExample,bankNameExample,addressExample,telephoneExample,faxExample,websiteExample,telexExample,eftExample,swiftExample),
                new Brand((int)idExample,brandExample),
                new Campaign((int)idExample,startDateExample,endDateExample,rateExample),
                new Category((short)idExample,titleExample),
                new City((short)idExample,cityNameExample),
                new Coupon((int)idExample,500),
                new District((short)idExample,(short)idExample,cityNameExample),
                new Faq((short)idExample,(short)idExample,titleExample,contentExample),
                new FaqCategory((short)idExample,titleExample),
                new FaqSubCategory((short)idExample,(short)idExample,titleExample),
                new GeneralInfo(stringKeyExample,titleExample),
                new Invoice(Invoice.Types.individual,(int)idExample,idExample,(short)idExample,(int)idExample,nameExample,nameExample,surnameExample,addressExample),
                new Order(idExample,(int)idExample,(int)idExample,(int)idExample,endDateExample),
                new OrderProduct((int)idExample,(int)idExample,(int)idExample,21,OrderProduct.OrderProductState.OnReply),
                new Product(45,125125125,(short)idExample,(int)idExample,rateExample,42,Product.WarrantyTypes.Day,(int)idExample,rateExample,421,nameExample,stringArrayExample,stringKeyExample,contentExample),
                new ProductCampaign((int)idExample,(int)idExample,(int)idExample),
                new ProductRate(endDateExample,(int)idExample,(int)idExample,boolExample,(int)idExample,3,contentExample,stringArrayExample),
                
                new Shop(ibanExample,phoneExample,phoneExample,Shop.FirmTypes.Incorporated,Shop.FirmProfiles.Importer,(short)idExample,123123
                ,(short)idExample,(short)idExample,22222222222,1234567890123456,phoneExample,(short)idExample,(short)idExample,(short)idExample
                ,1523,1234567890123456,(int)idExample,boolExample,usernameExample,passwordExample,nameExample,nameExample,surnameExample
                ,addressExample,"IT Manager",nameExample,emailExample,nameExample,surnameExample,bankNameExample,kepMailExample,websiteExample,
                emailExample,"For Example ltd. şti.",emailExample),
                
                new ShopProduct(ShopProduct.States.Onsale,(int)idExample,(int)idExample,21,rateExample,125,32,endDateExample,(int)idExample,124.42f,12,"dEF12-k3",new string[]{urlExample}),
                new Slide((int)idExample,2,urlExample,websiteExample),
                new SubCategory((short)idExample,(short)idExample,titleExample),
                new SubSubCategory((short)idExample,(short)idExample,titleExample),
                new TaxOffice((short)idExample,(short)idExample,(short)idExample,1250,"Nazilli Vergi Dairesi Müdürlüğü"),
                new User(boolExample,boolExample,boolExample,(int)idExample,phoneExample,endDateExample,emailExample,nameExample,surnameExample),
                new UserCoupon((int)idExample,(int)idExample,(int)idExample),
                new UserFavouriteProduct((int)idExample,(int)idExample,(int)idExample),
                new UserProductWillBeOrdered((int)idExample,(int)idExample,(int)idExample)
            };
        }

        public void initializeValidators(){
            validators=new List<IValidator>(){
                new AddressValidator(),
                new BankValidator(),
                new BankValidator(),
                new BrandValidator(),
                new CampaignValidator(),
                new CategoryValidator(),
                new CityValidator(),
                new CouponValidator(),
                new DistrictValidator(),
                new FaqValidator(),
                new FaqCategoryValidator(),
                new FaqSubCategoryValidator(),
                new GeneralInfoValidator(),
                new InvoiceValidator(),
                new OrderValidator(),
                new OrderProductValidator(),
                new ProductValidator(),
                new ProductCampaignValidator(),
                new ProductRateValidator(),
                new ShopValidator(),
                new ShopProductValidator(),
                new SlideValidator(),
                new SubCategoryValidator(),
                new SubSubCategoryValidator(),
                new TaxOfficeValidator(),
                new UserValidator(),
                new UserCouponValidator(),
                new UserFavouriteProductValidator(),
                new UserProductWillBeOrderedValidator()
            };
        }
        
        public void Dispose()
        {

        }
    }
}
