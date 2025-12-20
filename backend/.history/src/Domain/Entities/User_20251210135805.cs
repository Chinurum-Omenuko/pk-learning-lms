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

        public User(Guid id, string name, Email email, UserRole role, string passwordHash, DateTime createdAt, bool isActive, DateTime createdAt, DateTime lastUpdate, DateTime lastLogin)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Role = role ?? throw new ArgumentNullException(nameof(role));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            CreatedAt = createdAt;
            IsActive = isActive;
            LastUpdate = lastUpdate;
            LastLogin = lastLogin;
        }

        public void UpdateProfile(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.");
            Name = name;
        }

        public void ChangePassword(string newPasswordHash)
        {
            if (string.IsNullOrWhiteSpace(newPasswordHash)) throw new ArgumentException("PasswordHash cannot be empty.");
            PasswordHash = newPasswordHash;
        }
    }
}
