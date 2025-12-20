using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using backend.Src.Domain.Entities;

namespace backend.Src.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetAsync(Course course);
        Task<IReadOnlyList<Course>> GetAllAsync();
        Task<Course?> GetByIdAsync(Guid CourseId);
        Task AddAsync(Course newCourse);
        Task Update();
        Task Delete();
        
    }
}
