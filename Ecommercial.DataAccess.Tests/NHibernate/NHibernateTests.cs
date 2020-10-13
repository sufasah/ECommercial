using System.Linq;
using ECommercial.DataAccess.NHibarnate;
using ECommercial.DataAccess.NHibarnate.Helpers;
using ECommercial.Entites.concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ECommercial.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class tests
    {
        NhProductDal productDal = new NhProductDal(new PostgreSqlServerHelper());


        [TestMethod]
        public void Get_Product_From_Table()
        {
            Product value= new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme","Cargoşirket","Açıklama");

            Product res= productDal.Get(x=>x.Id==5);

            Assert.AreEqual(value,res);
        }
        [TestMethod]
        public void Get_Product_List_From_Table()
        {
            Product value= new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme","Cargoşirket","Açıklama");

            Product res= productDal.GetList(x=>x.Id==5).Single();

            Assert.AreEqual(value,res);
        }
        [TestMethod]
        public void Insert_Product_To_Table()
        {
            Product value= new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,0,10,20,"Deneme","Cargoşirket","Açıklama");

            Product res =productDal.Add(value);
            
            Assert.AreEqual(res,value);
        }

        [TestMethod]
        public void Update_Product_In_Table()
        {
            Product value= new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,5,10,20,"Deneme","Cargoşirket","Açıklama_Upated");

            Product res =productDal.Update(value);
            
            Assert.AreEqual(res,value);
        }

        [TestMethod]
        public void Delete_Product_From_Table()
        {
            Product value= new Product(5,1234,2,1,15,28,Product.WarrantyTypes.Day,0,10,20,"Deneme","Cargoşirket","Açıklama");

            productDal.Delete(value);
            
            Assert.AreEqual(1,1);
        }



    }
}