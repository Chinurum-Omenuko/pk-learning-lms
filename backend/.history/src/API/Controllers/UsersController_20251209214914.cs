using Microsoft.AspNetCore.Mvc;
using LMS.Src.Api.Middleware;
using LMS.Src.Api.DTOs.Requests;
using LMS.Src.Api.DTOs.Responses;

namespace backend.Src.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [JwtAuthMiddleware]
    [HttpGet("{id}")]
    public ActionResult<UserDto> GetUser(Guid id)
        => Ok(new UserDto(id, "example@lms.com", "Student"));
}
