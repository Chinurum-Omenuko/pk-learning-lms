using System;
using System.ArgumentException;
using System.ArgumentNullException;

namespace backend.Src.Domain.Entities
{
    public class Lesson
    {
        public Guid Id { get; private set; }
        public Guid CourseId { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public User Instructor { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Lesson(Guid id, Guid courseId, string title, string content)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            CourseId = courseId;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Content = content ?? string.Empty;
            CreatedAt = DateTime.UtcNow;
        }

        public void Update(string title, string content)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title required.");
            Title = title;
            Content = content ?? string.Empty;
        }
    }
}
