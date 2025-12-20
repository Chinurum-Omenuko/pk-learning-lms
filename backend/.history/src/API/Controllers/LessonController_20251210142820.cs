using backend.Src.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Src.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonsController : ControllerBase
{

}

public class AddLessonRequest
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
