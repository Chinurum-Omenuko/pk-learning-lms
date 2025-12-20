using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using backend.Src.Domain.Entities;

namespace backend.Src.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseAsync(Course course);
        Task<List<Course>> GetCoursesAsync();
        Task<Course> GetCourseByIdAsync(Course course);
        Task AddCourseAsync(Course newCourse);
        Task UpdateCourse();
        Task DeleteCourse();
        
    }
}
