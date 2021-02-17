using ECommercial.Business.Abstract.AbstractEntities; 
using ECommercial.Entities.concrete;
using Microsoft.AspNetCore.Mvc;
using ECommercial.WebApi.Controllers.BaseControllers;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    public class ProductsController:ApiController
    {
        
        private readonly IProductService _manager;
        public ProductsController(IProductService manager)
        {
            _manager=manager;
        }
        [HttpGet]
        public IActionResult GetAll(){
            var entity =_manager.GetAll();
            if(entity.Count==0)
                return NoResult();
            return ResponseJson(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id){
            var entity =_manager.GetByPrimaryKey(id);
            if(entity==null)
                return NoResult();
            return ResponseJson(entity);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Product body){
            var entity = _manager.Add(body);
            return ResponseJson(entity);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id){
            var entity = _manager.GetByPrimaryKey(id);
            if(entity==null)
                return NoResult();
            _manager.Delete(entity);
            return ResponseJson(entity);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody]Product body){
            var entity = _manager.Update(body);
            return ResponseJson(_manager.Update(entity));
        }

        private IActionResult NoResult(){
            return BadRequest("[{}]");
        }
    }
}