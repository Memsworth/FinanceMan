using Microsoft.AspNetCore.Mvc;

namespace FinanceMan.Server.Controllers;



[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{       
    [HttpGet]
    public void Get()
    {
        return;     
    }
}
