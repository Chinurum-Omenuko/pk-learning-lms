using System;
using System.Collections.Generic;


namespace backend.Src.Domain.Entities
{
    public class Quiz
    {
        public Guid Id { get; private set; }
        public Guid CourseId { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public IDictionary<Guid, string> Questions { get; private set; } = new Dictionary<Guid, string>();

        public Quiz(Guid id, Guid courseId, string title)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            CourseId = courseId;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            CreatedAt = DateTime.UtcNow;
        }
    }
}
