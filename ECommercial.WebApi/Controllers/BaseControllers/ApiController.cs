using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [Route("api/v1/[controller]")]
    public class ApiController:Controller
    {
        private readonly JsonSerializerOptions _jsonOptions;
        public ApiController()
        {
            _jsonOptions= new JsonSerializerOptions(){
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented=true
            };
        }
        protected JsonResult ResponseJson(object data,string msg="Operation is successful."){
            return Json(new {
                Success=true,
                Message=msg,
                Data=data
            }, _jsonOptions);
        }
        protected IActionResult NoResult(){
            return Json(new {
                Success=false,
                Message="No Result",
                Data=new string[]{}
            }, _jsonOptions);
        }
    }
}