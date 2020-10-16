/*using System;
using System.Collections.Generic;
using ECommercial.DataAccess.NHibarnate;
using ECommercial.DataAccess.NHibarnate.Helpers;
using ECommercial.Entites.concrete;
using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization=true)]
namespace ECommercial.DataAccess.Tests.NHibernate
{

    public class NHibernateTests
    {
        private NhProductDal _productDal = new NhProductDal(new PostgreSqlServerHelper());
        private Product _productInserted;
        [Fact]
        public void Product_Get_From_Database()
        {
            List<string> properties= new List<string>();
            properties.Add("Özellik:1");
            Product value = new Product(5,1234,2,1,15.00f,28,Product.WarrantyTypes.Day,5,10.00f,20,"Deneme","Cargoşirket","Açıklama","Özellik:1");

            Product res = _productDal.Get(x=>x.Id==5);

            Assert.Equal(res,value);
        }
        
        [Fact]
        public void Product_GetList_From_Database()
        {
            List<string> properties= new List<string>();
            properties.Add("Özellik:1");
            Product value = new Product(5,1234,2,1,15.00f,28,Product.WarrantyTypes.Day,5,10.00f,20,"Deneme","Cargoşirket","Açıklama","Özellik:1");

            List<Product> res = _productDal.GetList(x=>x.Id==5);

            Assert.Equal<Product>(value,res[0]);
        }

        [Fact(Skip="To see database")]
        public void Product_Insert_To_Database()
        {
            List<string> properties= new List<string>();
            properties.Add("Özellik:1");
            Product value = new Product(6,new Random().Next(1,Int16.MaxValue),2,1,15.00f,28,Product.WarrantyTypes.Day,0,10.00f,20,"Deneme","Cargoşirket","Açıklama","Özellik:1");

            Product res = _productDal.Add(value);
            _productInserted=res;

            Assert.Equal<Product>(res,value);

        }
        [Fact]
        public void Product_Delete_From_Database()
        {
            Product res = _productDal.Add(_productInserted);

            Assert.Equal<Product>(res,_productInserted);
        }

        [Fact]
        public void Product_Update_To_Database()
        {
            List<string> properties= new List<string>();
            properties.Add("Özellik:1");
            Product value = new Product(5,1234,2,1,15.00f,28,Product.WarrantyTypes.Day,5,10.00f,20,"Deneme_updated","Cargoşirket","Açıklama_updated","Özellik:1");

            Product res = _productDal.Add(value);

            Assert.Equal<Product>(res,value);
        }

    }
}*/