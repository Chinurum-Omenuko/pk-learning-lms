using Microsoft.AspNetCore.Mvc;
using LMS.Src.Api.DTOs.Requests;
using LMS.Src.Api.DTOs.Responses;

namespace API.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateCourse(CreateCourseRequest req)
        => Ok("Course created");

    [HttpGet]
    public ActionResult<List<CourseDto>> GetCourses()
        => Ok(new List<CourseDto> {
            new ("Intro to C#", "Learn foundations"),
            new ("Backend Architecture", "MVC + CQRS + Clean DDD")
        });
}
