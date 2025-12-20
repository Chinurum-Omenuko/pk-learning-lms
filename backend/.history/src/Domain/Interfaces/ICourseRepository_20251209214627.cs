using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using backend.Src.Domain.Entities;

namespace backend.Src.Domain.Repositories
{
    public interface ICourseRepository
    {
        Task<Course?> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task<IEnumerable<Course>> GetAllAsync(CancellationToken ct = default);
        Task AddAsync(Course course, CancellationToken ct = default);
        Task UpdateAsync(Course course, CancellationToken ct = default);
        Task DeleteAsync(Guid id, CancellationToken ct = default);
    }
}
