using System.Linq;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entites.concrete;
using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace ECommercial.DataAccess.Tests.EntityFramework
{
    public class ProductTests
    {

        private EFProductDal _eFProductDal = new EFProductDal(); 
        private ProductEqualityComparer _productEqualityComparer = new ProductEqualityComparer();


        [Fact]
        public void Get_Product_From_Database()
        {
            Product value = new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme",new string[]{"Özellik:1"},"Cargoşirket","Açıklama");

            Product res = _eFProductDal.Get(x=>x.Id==value.Id);

            Assert.Equal<Product>(value,res,_productEqualityComparer);
        }
        
        [Fact]
        public void GetList_Product_From_Database()
        {
            Product value = new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme",new string[]{"Özellik:1"},"Cargoşirket","Açıklama");

            Product res = _eFProductDal.GetList(x=>x.Id==value.Id).SingleOrDefault();

            Assert.Equal<Product>(value,res,_productEqualityComparer);
        }

        [Fact]
        public void Insert_Product_To_Database()
        {
            Product value = new Product(5,12345,2,1,15,28,Product.WarrantyTypes.Day,0,10,20,"Deneme",new string[]{"Özellik:1"},"CargoşirketEklenen","Açıklama");
            
            Product res = _eFProductDal.Add(value);

            Assert.Equal<Product>(value,res,_productEqualityComparer);
        }

        [Fact]
        public void Update_Inserted_Product_In_Database()
        {
           Product value = _eFProductDal.Get(p=>p.Barcode==12345);
           
           Product res = _eFProductDal.Update(value);

           Assert.Equal<Product>(value,res,_productEqualityComparer);
        }

        [Fact]
        public void Delete_Inserted_Product_From_Database()
        {
           Product value = _eFProductDal.Get(p=>p.Barcode==12345);
           
           _eFProductDal.Delete(value);

           Assert.Equal(1,1);
        }


    }
}