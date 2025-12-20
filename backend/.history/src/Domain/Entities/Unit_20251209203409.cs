using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Unit
    {
        public Guid Id { get; private set; }
        public string Title {get; private set; }
        public List<Lesson> Lessons { get; private set; }
        public User Instructor { get; private set; }
        

        public Unit(Guid id, string title, List<Lesson> lessons, User instructor)
        {
            Id = id;
            Title = title;
            Lessons = lessons;
            Instructor = instructor;
        }
    }
}