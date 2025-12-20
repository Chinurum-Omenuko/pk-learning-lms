using backend.Src.Application.Services;
using Microsoft.AspNetCore.Mvc;


namespace backend.Src.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProgressController : ControllerBase
{

}

public class UpdateProgressRequest
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
    public int ProgressPercent { get; set; }
}
