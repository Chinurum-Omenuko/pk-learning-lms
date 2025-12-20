using System;
using System.Text.RegularExpressions;


namespace backend.Src.Domain.ValueObjects
{
    public class Email
    {
        private static readonly Regex EmailRegex = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email cannot be empty.");
            if (!EmailRegex.IsMatch(value)) throw new ArgumentException("Invalid email format.");
            Value = value.Trim().ToLowerInvariant();
        }

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is Email other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
