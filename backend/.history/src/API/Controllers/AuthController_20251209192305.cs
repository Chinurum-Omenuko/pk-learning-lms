using Microsoft.AspNetCore.Mvc;
using LMS.Src.Api.DTOs.Requests;
using LMS.Src.Api.DTOs.Responses;

namespace API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public ActionResult<AuthResponse> Login(LoginRequest request)
    {
        // You will later validate via Domain + Application Layers
        return Ok(new AuthResponse { Token = "fake.jwt.token" });
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterUserRequest request)
        => Ok("User registered (placeholder)");
}
