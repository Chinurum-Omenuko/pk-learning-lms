using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Src.Domain.Entities
{
    public class Course
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid? OwnerId { get; private set; } // instructor or organization owner
        public IReadOnlyList<Lesson> Lessons => _lessons.AsReadOnly();
        private readonly List<Lesson> _lessons = new();

        public bool IsPublished { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Course(Guid id, string title, string description, Guid? ownerId = null)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? string.Empty;
            OwnerId = ownerId;
            CreatedAt = DateTime.UtcNow;
        }

        public void Publish()
        {
            if (!_lessons.Any()) throw new Exceptions.ValidationException("Course must have at least one lesson to publish.");
            IsPublished = true;
        }

        public void Unpublish() => IsPublished = false;

        public Lesson AddLesson(string title, string content)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new Exceptions.ValidationException("Lesson title required.");
            var lesson = new Lesson(Guid.NewGuid(), Id, title, content);
            _lessons.Add(lesson);
            return lesson;
        }

        public void RemoveLesson(Guid lessonId)
        {
            var existing = _lessons.FirstOrDefault(l => l.Id == lessonId);
            if (existing == null) throw new Exceptions.NotFoundException("Lesson not found.");
            _lessons.Remove(existing);
        }

        public void Update(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new Exceptions.ValidationException("Title required.");
            Title = title;
            Description = description ?? string.Empty;
        }
    }
}
