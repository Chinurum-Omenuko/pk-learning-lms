using System;
using System.ArgumentException;

namespace backend.Src.Domain.ValueObjects
{
    public class UserRole
    {
        public string Value { get; }

        private UserRole(string value) => Value = value;

        public static UserRole Student => new UserRole("Student");
        public static UserRole Instructor => new UserRole("Instructor");
        public static UserRole Admin => new UserRole("Admin");

        public static UserRole FromString(string role)
        {
            if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Role cannot be empty.");
            role = role.Trim();
            return role switch
            {
                "Student" => Student,
                "Instructor" => Instructor,
                "Admin" => Admin,
                _ => new UserRole(role)
            };
        }

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is UserRole other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
