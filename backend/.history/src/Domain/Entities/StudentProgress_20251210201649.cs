using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Src.Domain.Entities
{
    public class StudentProgress
    {
        public Guid UserId { get; private set; }
        public Guid CourseId { get; private set; }
        private readonly List<Guid> _completedLessonIds = new();
        public IReadOnlyCollection<Guid> CompletedLessons => _completedLessonIds.AsReadOnly();
        public bool IsCompleted { get; private set; }
        public DateTime LastUpdatedAt { get; private set; }

        public StudentProgress(Guid userId, Guid courseId)
        {
            UserId = userId;
            CourseId = courseId;
            IsCompleted = false;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
