using System;
using backend.Src.Domain.ValueObjects; // ✅ correct


namespace backend.Src.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Email Email { get; private set; }
        public UserRole Role { get; private set; }
        public string PasswordHash { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public User(Guid id, string name, Email email, UserRole role, string passwordHash)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Role = role ?? throw new ArgumentNullException(nameof(role));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            CreatedAt = DateTime.UtcNow;
        }

        public void UpdateProfile(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exceptions.ValidationException("Name cannot be empty.");
            Name = name;
        }

        public void ChangePassword(string newPasswordHash)
        {
            if (string.IsNullOrWhiteSpace(newPasswordHash)) throw new Exceptions.ValidationException("PasswordHash cannot be empty.");
            PasswordHash = newPasswordHash;
        }
    }
}
