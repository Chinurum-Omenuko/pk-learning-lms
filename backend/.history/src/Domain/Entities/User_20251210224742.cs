using System;
using backend.Src.Domain.ValueObjects;



namespace backend.Src.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public UserRole Role { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsActive { get; private set; } 

        protected User() { }
        public User(Guid id, string firstName, string lastName, string email, UserRole role, string passwordHash, bool isActive)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = new Email(email).Value ?? throw new ArgumentNullException(nameof(email));
            Role = role ?? throw new ArgumentNullException(nameof(role));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            CreatedAt = DateTime.UtcNow;
            IsActive = isActive;
        }
    }
}
