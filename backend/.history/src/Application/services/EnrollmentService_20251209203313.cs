using Application.Validators;

namespace Application.Services;

public class EnrollmentService
{
    private readonly EnrollmentValidator _validator;

    public EnrollmentService(EnrollmentValidator validator)
    {
        _validator = validator;
    }

    public string EnrollUser(Guid userId, Guid courseId)
    {
        _validator.ValidateEnrollment(userId, courseId);

        return $"User {userId} enrolled in course {courseId}";
    }

    public string RecordProgress(Guid userId, Guid courseId, int progressPercent)
    {
        return $"Progress updated: {progressPercent}% for user {userId} in course {courseId}";
    }
}
