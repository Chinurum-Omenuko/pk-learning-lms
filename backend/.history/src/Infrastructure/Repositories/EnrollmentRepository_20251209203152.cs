using backend.Src.Domain.Entities;
using backend.Src.Domain.Interfaces;
using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Src.Infrastructure.Repositories;

public class EnrollmentRepository : IEnrollmentRepository
{
    private readonly AppDbContext _context;

    public EnrollmentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Enrollment?> GetEnrollmentAsync(Guid userId, Guid courseId)
        => await _context.Enrollments
            .FirstOrDefaultAsync(e => e.UserId == userId && e.CourseId == courseId);

    public async Task AddAsync(Enrollment enrollment)
        => await _context.Enrollments.AddAsync(enrollment);
}
