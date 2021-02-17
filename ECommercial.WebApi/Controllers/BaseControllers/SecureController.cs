using Microsoft.AspNetCore.Authorization;

namespace ECommercial.WebApi.Controllers.BaseControllers
{
    [Authorize]
    public class SecureController:ApiController
    {
        
    }
}