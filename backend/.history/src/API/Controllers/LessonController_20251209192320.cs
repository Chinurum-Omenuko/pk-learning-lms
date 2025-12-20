using backend.Src.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonsController : ControllerBase
{
    private readonly CourseService _courseService;

    public LessonsController(CourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpPost("{courseId}/add")]
    public IActionResult AddLesson(Guid courseId, [FromBody] AddLessonRequest request)
    {
        var result = _courseService.AddLesson(courseId, request.Title, request.Content);
        return Ok(new { message = result });
    }
}

public class AddLessonRequest
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
