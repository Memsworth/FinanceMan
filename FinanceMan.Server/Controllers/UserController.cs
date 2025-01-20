using System.Net;
using FinanceMan.Server.Services;
using FinanceMan.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceMan.Server.Controllers;

[Route("api/[controller]")]
[ApiController] 
public class UserController(UserService userService) : ControllerBase
{
    // GET
    [HttpGet]
    //[Authorize]
    public async Task<IActionResult> GetUsers()
    {
        var users = await userService.GetUsersAsync();
        return Ok(new ApiResponse<List<User>>()
        {
            Data = users,
            StatusCode = HttpStatusCode.OK,
            Title = "Users",
            Detail = "List of users",
            Errors = []
        });
    }
}