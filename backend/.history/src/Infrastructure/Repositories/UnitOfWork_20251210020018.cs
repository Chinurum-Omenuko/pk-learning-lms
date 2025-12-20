using backend.Src.Domain.Repositories;
using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using backend.Src.Domain.Interfaces;


namespace backend.Src.Infrastructure.Repositories;


public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IUserRepository Users { get; }
    public ICourseRepository Courses { get; }
    // public IEnrollmentRepository Enrollments { get; }

    public UnitOfWork(
        AppDbContext context,
        IUserRepository userRepo,
        ICourseRepository courseRepo)
    {
        _context = context;
        Users = userRepo;
        Courses = courseRepo;
        Enrollments = enrollmentRepo;
    }

    public async Task<int> SaveChangesAsync()
        => await _context.SaveChangesAsync();
}
