using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ECommercial.WebApi.Controllers
{

    [Route("/")]
    public class HomeController:Controller
    {
        
        public HomeController()
        {
        }

        public IActionResult Index(){
            return View();
        }

    }
}