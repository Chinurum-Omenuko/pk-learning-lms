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

        public void MarkLessonComplete(Guid lessonId, int totalLessons)
        {
            if (!_completedLessonIds.Contains(lessonId))
            {
                _completedLessonIds.Add(lessonId);
                LastUpdatedAt = DateTime.UtcNow;
            }

            if (totalLessons > 0 && _completedLessonIds.Count >= totalLessons)
            {
                IsCompleted = true;
            }
        }

        public double ProgressPercent(int totalLessons)
        {
            if (totalLessons <= 0) return 0;
            return Math.Round((double)_completedLessonIds.Count / totalLessons * 100, 2);
        }

        public void Complete()
        {
            IsCompleted = true;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
