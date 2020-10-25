using System;
using ECommercial.Business.Concrete.Managers.EntityManagers;
using ECommercial.Business.DependencyResolvers.Ninject;
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
