using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using ECommercial.WebApi.Controllers.BaseControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers
{

    public class ShopsController:ApiController
    {
        
        private readonly IShopService _manager;
        public ShopsController(IShopService manager)
        {
            _manager=manager;
        }
        [Authorize]
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
        public IActionResult Post([FromBody]Shop body){
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
        public IActionResult Put([FromBody]Shop body){
            var entity = _manager.Update(body);
            return ResponseJson(_manager.Update(entity));
        }

        

    }
}