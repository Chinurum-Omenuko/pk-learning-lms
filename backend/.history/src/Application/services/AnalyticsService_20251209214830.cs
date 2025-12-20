namespace backend.Src.Application.Services;

public class AnalyticsService
{
    public string GetCompletionRate(Guid courseId)
    {
        // Placeholder 74%
        return "74%";
    }

    public string GetTopCourses()
    {
        return "Top courses: Intro to C#, ASP.NET Backend";
    }

    public string GetUserStats(Guid userId)
    {
        return $"User {userId} stats placeholder";
    }
}
