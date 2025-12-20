using backend.Src.Domain.Entities;
using backend.Src.Domain.Interfaces;
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


    
}
