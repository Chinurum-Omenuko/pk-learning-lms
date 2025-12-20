using System.Threading;
using System.Threading.Tasks;
using backend.Src.Domain.Entities;

namespace backend.Src.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        ICourseRepository Courses { get; }
        // IEnrollmentRepository Enrollments { get; }
        // IQuizRepository Quizzes { get; }

        Task<int> SaveChangesAsync(CancellationToken ct = default);
    }
}
