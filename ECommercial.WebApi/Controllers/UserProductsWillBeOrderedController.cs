using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entities.concrete;
using Microsoft.AspNetCore.Mvc;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{
    public class UserProductsWillBeOrderedController:ApiController
    {
        
        private readonly IUserProductWillBeOrderedService _manager;
        public UserProductsWillBeOrderedController(IUserProductWillBeOrderedService manager)
        {
            _manager=manager;
        }
        [HttpGet]
        public IActionResult GetAll(){
            var entity =_manager.GetAll();
            if(entity.Count==0)
                return NoResult();
            return Ok(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id){
            var entity =_manager.GetByPrimaryKey(id);
            if(entity==null)
                return NoResult();
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Post([FromBody]UserProductWillBeOrdered body){
            var entity = _manager.Add(body);
            return Ok(entity);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id){
            var entity = _manager.GetByPrimaryKey(id);
            if(entity==null)
                return NoResult();
            _manager.Delete(entity);
            return Ok(entity);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody]UserProductWillBeOrdered body){
            var entity = _manager.Update(body);
            return Ok(_manager.Update(entity));
        }

        private IActionResult NoResult(){
            return BadRequest("[{}]");
        }
    }
}