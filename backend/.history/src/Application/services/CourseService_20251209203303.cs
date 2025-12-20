using Application.Validators;

namespace backend.Src.Application.Services;


public class CourseService
{
    private readonly CourseValidator _validator;

    public CourseService(CourseValidator validator)
    {
        _validator = validator;
    }

    public string CreateCourse(string title, string description)
    {
        _validator.ValidateCreate(title, description);

        // Placeholder logic
        return $"Course '{title}' created.";
    }

    public string UpdateCourse(Guid courseId, string title, string description)
    {
        _validator.ValidateUpdate(courseId, title, description);

        return $"Course '{title}' updated.";
    }

    public string AddLesson(Guid courseId, string lessonTitle, string lessonContent)
    {
        // Validation omitted for simplicity
        return $"Lesson '{lessonTitle}' added to course {courseId}";
    }
}
