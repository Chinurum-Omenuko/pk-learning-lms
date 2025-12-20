using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Src.Domain.Entities
{
    public class StudentProgress
    {
        // Primary key (EF Core convention recognizes 'Id')
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid CourseId { get; private set; }
        private readonly List<Guid> _completedLessonIds = new();
        public IReadOnlyCollection<Guid> CompletedLessons => _completedLessonIds.AsReadOnly();
        public bool IsCompleted { get; private set; }
        public DateTime LastUpdatedAt { get; private set; }

        // Parameterless ctor for EF Core
        private StudentProgress() { }

        public StudentProgress(Guid userId, Guid courseId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            CourseId = courseId;
            IsCompleted = false;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
