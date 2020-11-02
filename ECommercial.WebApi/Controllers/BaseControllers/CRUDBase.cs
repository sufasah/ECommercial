using ECommercial.Core.Business;
using ECommercial.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [ApiController]
    [Route("api/")]
    abstract public class CRUDBase<T>:ControllerBase
        where T:class,IEntity,new()
    {
        private IService<T> Manager;

        protected CRUDBase(IService<T> manager)
        {
            Manager = manager;
        }

        [Route("products")]
        public IActionResult GetAll(){
            return Ok(Manager.GetAll());
        }
        [Route((nameof(T)+"s/{id}"))]
        public IActionResult Get(string id){
            return Ok(Manager.GetByPrimaryKey(id));
        }
        [Route((nameof(T)+"s"))]
        public IActionResult Post(){
            var x =Response.Body;
            return Ok();
        }
      /*  [Route((nameof(T)+"s/{id}"))]
        public IActionResult Get(string id){
            return Ok(Manager.GetByPrimaryKey(id));
        }
        [Route((nameof(T)+"s/{id}"))]
        public IActionResult Get(string id){
            return Ok(Manager.GetByPrimaryKey(id));
        }*/
    }
}