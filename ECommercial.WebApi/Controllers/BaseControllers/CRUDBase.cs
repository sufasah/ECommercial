using ECommercial.Core.Business;
using ECommercial.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [ApiController]
    abstract public class CRUDBase<T>:ControllerBase
        where T:class,IEntity,new()
    {
        private IService<T> Manager;

        protected CRUDBase(IService<T> manager)
        {
            Manager = manager;
        }
        [HttpGet]
        public IActionResult GetAll(){
            return Ok(Manager.GetAll());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id){
            var entity =Manager.GetByPrimaryKey(id);
            if(entity==null)
            return Ok("no entity");
            else
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Post([FromBody]T body){
            var entity = Manager.Add(body);
            return Ok(entity);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id){
            var entity = Manager.GetByPrimaryKey(id);
            if(entity==null)
            return Ok("no record");
            else{
                Manager.Delete(entity);
                return Ok(entity);
            }
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody]T body){
            var entity = Manager.Update(body);
            return Ok(Manager.Update(entity));
        }
    }
}