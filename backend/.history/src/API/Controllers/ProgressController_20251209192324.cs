using backend.Src.Application.Services;
using Microsoft.AspNetCore.Mvc;
using LMS.Src.Api.DTOs.Requests;
using LMS.Src.Api.DTOs.Responses;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProgressController : ControllerBase
{
    private readonly EnrollmentService _enrollmentService;
    private readonly AnalyticsService _analyticsService;

    public ProgressController(EnrollmentService enrollmentService, AnalyticsService analyticsService)
    {
        _enrollmentService = enrollmentService;
        _analyticsService = analyticsService;
    }

    [HttpPost("update")]
    public IActionResult UpdateProgress([FromBody] UpdateProgressRequest request)
    {
        var result = _enrollmentService.RecordProgress(
            request.UserId,
            request.CourseId,
            request.ProgressPercent
        );

        return Ok(new { message = result });
    }

    [HttpGet("course/{courseId}/completion")]
    public IActionResult CourseCompletion(Guid courseId)
    {
        var rate = _analyticsService.GetCompletionRate(courseId);
        return Ok(new { completionRate = rate });
    }

    [HttpGet("user/{userId}/stats")]
    public IActionResult UserStats(Guid userId)
    {
        var stats = _analyticsService.GetUserStats(userId);
        return Ok(new { stats });
    }
}

public class UpdateProgressRequest
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
    public int ProgressPercent { get; set; }
}
