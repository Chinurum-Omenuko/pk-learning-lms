using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
namespace backend.Src.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        ICourseRepository Courses { get; }
        IEnrollmentRepository Enrollments { get; }
        IQuizRepository Quizzes { get; }

        Task<int> SaveChangesAsync(CancellationToken ct = default);
    }
}
