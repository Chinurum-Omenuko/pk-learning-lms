namespace backend.Src.Application.Validators;

public class CourseValidator
{
    public void ValidateCreate(string title, string description)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required");

        if (title.Length < 3)
            throw new ArgumentException("Title must be at least 3 characters");
    }

    public void ValidateUpdate(Guid courseId, string title, string description)
    {
        if (courseId == Guid.Empty)
            throw new ArgumentException("CourseId cannot be empty");

        ValidateCreate(title, description);
    }
}
