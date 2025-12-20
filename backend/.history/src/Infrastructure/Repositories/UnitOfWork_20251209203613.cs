using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IUserRepository Users { get; }
    public ICourseRepository Courses { get; }
    public IEnrollmentRepository Enrollments { get; }

    public UnitOfWork(
        AppDbContext context,
        IUserRepository userRepo,
        ICourseRepository courseRepo,
        IEnrollmentRepository enrollmentRepo)
    {
        _context = context;
        Users = userRepo;
        Courses = courseRepo;
        Enrollments = enrollmentRepo;
    }

    public async Task<int> SaveChangesAsync()
        => await _context.SaveChangesAsync();
}
