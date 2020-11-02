using System;
using ECommercial.Core.Business;
using ECommercial.Core.Entities;
using ECommercial.Entites.concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [ApiController]
    [Route("api/{entityName}s/")]
    abstract public class CRUDBase<T>:ControllerBase
        where T:class,IEntity,new()
    {
        private IService<T> Manager;

        protected CRUDBase(IService<T> manager)
        {
            Manager = manager;
        }
        [HttpGet]
        public IActionResult GetAll(string entityName){
            CheckEntityName(entityName);
            return Ok(Manager.GetAll());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string entityName,string id){
            CheckEntityName(entityName);
            var entity =Manager.GetByPrimaryKey(id);
            if(entity==null)
            return Ok("no entity");
            else
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Post(string entityName,[FromBody]T body){
            CheckEntityName(entityName);
            var entity = Manager.Add(body);
            return Ok(entity);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string entityName,string id){
            CheckEntityName(entityName);
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
        public IActionResult Put(string entityName,[FromBody]T body){
            CheckEntityName(entityName);
            var entity = Manager.Update(body);
            return Ok(Manager.Update(entity));
        }

        private bool CheckEntityName(string entityName){
            return typeof(T).Name.ToLower()==entityName;
        }
    }
}