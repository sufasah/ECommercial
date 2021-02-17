using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [Route("api/v1/[controller]")]
    public class ApiController:Controller
    {
        public JsonResult ResponseJson(object data,string msg="Operation is successful."){
            return Json(new {
                Success=true,
                Message=msg,
                Data=data
            }, new JsonSerializerOptions(){
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented=true

            });
        }
    }
}