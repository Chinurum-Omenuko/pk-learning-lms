using System;


namespace backend.Src.Domain.ValueObjects
{
    public class UserRole
    {
        public Guid Id {get; private set; }
        public string Value { get; }

        private UserRole(string value) => Value = value;

        public static UserRole Student => new UserRole("Student");
        public static UserRole Instructor => new UserRole("Instructor");
        public static UserRole Admin => new UserRole("Admin");

        protected UserRole() { }

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
