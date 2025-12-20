using Microsoft.AspNetCore.Mvc;
using LMS.Src.Api.DTOs.Requests;
using LMS.Src.Api.DTOs.Responses;

namespace API.Controllers;

[ApiController]
[Route("api/enrollment")]
public class EnrollmentController : ControllerBase
{
    [HttpPost]
    public IActionResult Enroll(EnrollRequest req)
        => Ok(new EnrollmentDto(req.UserId, req.CourseId, DateTime.UtcNow));

    public IActionResult Unenroll(UnenrollRequest req)
    {
        return Ok();
    }
}
