using System;
using backend.Src.Domain.ValueObjects;



namespace backend.Src.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Email Email { get; private set; }
        public UserRole Role { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsActive { get; private set; } 
        public DateTime LastUpdate { get; private set; }
        public DateTime LastLogin { get; private set; }

        public User(Guid id, string firstName, string lastName, Email email, UserRole role, string passwordHash, bool isActive, DateTime lastUpdate, DateTime lastLogin)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Role = role ?? throw new ArgumentNullException(nameof(role));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            CreatedAt = DateTime.UtcNow;
            IsActive = isActive;
            LastUpdate = lastUpdate;
            LastLogin = lastLogin;
        }

        public void UpdateProfile(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("FirstName cannot be empty.");
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("LastName cannot be empty.");
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangePassword(string newPasswordHash)
        {
            if (string.IsNullOrWhiteSpace(newPasswordHash)) throw new ArgumentException("PasswordHash cannot be empty.");
            PasswordHash = newPasswordHash;
        }
    }
}
