using backend.Src.Domain.Entities;
using backend.Src.Domain.Repositories;
using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Src.Infrastructure.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Course?> GetByIdAsync(Guid id)
        => await _context.Courses.Include(c => c.Lessons)
                                 .FirstOrDefaultAsync(c => c.Id == id);

    public async Task<IEnumerable<Course>> GetAllAsync()
        => await _context.Courses.ToListAsync();

    public async Task AddAsync(Course course)
        => await _context.Courses.AddAsync(course);

    public void Update(Course course)
        => _context.Courses.Update(course);
}
