using System;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Concrete.EntityFramework;
using ECommercial.DataAccess.Concrete.EntityFramework.EFEntityDals;
using ECommercial.DataAccess.EntityFramework;
using ECommercial.Entites.concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.MVC.Controllers
{
    [ApiController]
    [Route("")]
    public class MyController : ControllerBase
    {

        [HttpGet]
        public String GetMethod(){
            EntityManager entityManager = new EntityManager(new EFEntityDal<Product>(new ECommercialContext()));
            IService<Product> productManager = new ProductManager(new EFProductDal(),entityManager.GetPrimaryKeyMember());
            return productManager.GetByPrimaryKey(5).ToString();
        }
    }
}
