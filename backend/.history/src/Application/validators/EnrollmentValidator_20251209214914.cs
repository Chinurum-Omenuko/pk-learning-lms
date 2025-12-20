namespace backend.Src.Application.Validators;

public class EnrollmentValidator
{
    public void ValidateEnrollment(Guid userId, Guid courseId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId is required");

        if (courseId == Guid.Empty)
            throw new ArgumentException("CourseId is required");
    }
}
