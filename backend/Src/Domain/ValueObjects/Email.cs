using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;


namespace backend.Src.Domain.ValueObjects
{

    public class Email
    {
        private static readonly Regex EmailRegex = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public string Value { get; }

        protected Email() { }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email cannot be empty.");
            if (!EmailRegex.IsMatch(value)) throw new ArgumentException("Invalid email format.");
            Value = value.Trim().ToLowerInvariant();
        }
    }
}
