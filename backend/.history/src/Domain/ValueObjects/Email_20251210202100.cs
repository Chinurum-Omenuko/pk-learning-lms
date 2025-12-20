using System;
using System.Text.RegularExpressions;


namespace backend.Src.Domain.ValueObjects
{
    public class Email
    {
        public Guid Id {get; private set; }
        private static readonly Regex EmailRegex = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public string Value { get; }

        protected Email() { }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email cannot be empty.");
            if (!EmailRegex.IsMatch(value)) throw new ArgumentException("Invalid email format.");
            Id = Guid.NewGuid();
            Value = value.Trim().ToLowerInvariant();
        }
    }
}
