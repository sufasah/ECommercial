using System;
using ECommercial.Business.Concrete.Managers;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Business.DependencyResolvers.Ninject;
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
            ProductManager productManager = InstanceFactory.GetInstance<ProductManager>(new BusinessModule());
            return productManager.GetByPrimaryKey(5).ToString();
        }
    }
}
