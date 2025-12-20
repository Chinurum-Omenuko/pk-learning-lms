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
        IReadOnlyList<Course> GetAllAsync();
        Task<Course> GetByIdAsync(Course course);
        Task AddAsync(Course newCourse);
        Task Update();
        Task Delete();
        
    }
}
