using System;
namespace backend.src.Domain.Entities
{
    public class Enrollment
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid CourseId { get; private set; }
        public DateTime EnrolledAt { get; private set; }
        public EnrollmentStatus Status { get; private set; }
        public StudentProgress Progress { get; private set; }

        public Enrollment(Guid id, Guid userId, Guid courseId)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            UserId = userId;
            CourseId = courseId;
            EnrolledAt = DateTime.UtcNow;
            Status = EnrollmentStatus.Active;
            Progress = new StudentProgress(UserId, CourseId);
        }

        public void Complete()
        {
            Status = EnrollmentStatus.Completed;
            Progress.Complete();
        }

        public void Cancel()
        {
            Status = EnrollmentStatus.Cancelled;
        }
    }

    public enum EnrollmentStatus
    {
        Active,
        Completed,
        Cancelled
    }
}
