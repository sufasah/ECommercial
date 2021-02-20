using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Mvc;

namespace ECommercial.WebApi.Controllers
{
    
    public class ErrorController : Controller
    {
      [Route("Error/{statusCode}")]
      public IActionResult Error(string statusCode){
          return new JsonResult(new {
              Success=false,
              Message="An Error occured.",
              StatusCode=statusCode,
              Data = new string[]{}
          },new JsonSerializerOptions(){
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented=true
            });
      }  
    }
}