using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entites.concrete;
using Microsoft.AspNetCore.Mvc;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("api/roles")]
    public class RoleController:Controller
    {
        
        private IRoleService _manager;
        public RoleController(IRoleService manager)
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
        public IActionResult Post([FromBody]Role body){
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
        public IActionResult Put([FromBody]Role body){
            var entity = _manager.Update(body);
            return Ok(_manager.Update(entity));
        }

        private IActionResult NoResult(){
            return BadRequest("[{}]");
        }
    }
}