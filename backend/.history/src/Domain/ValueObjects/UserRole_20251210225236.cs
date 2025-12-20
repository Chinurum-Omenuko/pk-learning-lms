using System;
using Microsoft.EntityFrameworkCore;


namespace backend.Src.Domain.ValueObjects
{
    [Keyless]
    public class UserRole
    {
        public string Value { get; }

        protected UserRole() { }

        public UserRole(string value) => Value = value;

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

    }
}
