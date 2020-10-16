using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entites.concrete;
using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace ECommercial.DataAccess.Tests.EntityFramework
{

    public class NHibernateTests
    {

        private EFProductDal _eFProductDal = new EFProductDal(); 

        [Fact]
        public void Product_Get_From_Database()
        {
            Product value = new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme",new string[]{"Özellik:1"},"Cargoşirket","Açıklama");

            Product res = _eFProductDal.Get(x=>x.Id==value.Id);

            Assert.True(value.Equals(res));
        }
        
        [Fact]
        public void Product_GetList_From_Database()
        {
           
        }

        [Fact]
        public void Product_Insert_To_Database()
        {
            

        }
        [Fact]
        public void Product_Delete_From_Database()
        {
          
        }

        [Fact]
        public void Product_Update_To_Database()
        {
           
        }

    }
}