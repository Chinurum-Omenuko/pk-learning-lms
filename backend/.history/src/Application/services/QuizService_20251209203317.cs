namespace Application.Services;


public class QuizService
{
    public string CreateQuiz(Guid courseId, string title)
    {
        return $"Quiz '{title}' created for course {courseId}";
    }

    public int GradeQuiz(Guid quizId, Dictionary<Guid, string> answers)
    {
        // Placeholder grading logic
        return 85; // pretend grade
    }
}
