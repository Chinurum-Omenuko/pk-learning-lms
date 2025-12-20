using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using backend.Src.Domain.Entities;

namespace backend.Src.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseAsync();
        Task<Course> GetCourseByIdAsync();
        Task AddCourseAsync();

        Task RemoveCourse();
        
    }
}
